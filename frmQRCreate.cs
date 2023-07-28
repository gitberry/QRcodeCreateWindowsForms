using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCreate
{
    public partial class QRCreate : Form
    {
        public QRCreate()
        {
            InitializeComponent();
            FormText(false);
        }

        Bitmap theQrImage = null;
        int pixelsPerBlock = 20;
        int lastSQuare = -1;
        string FormTextBase = "QR Create";

        private void btnRender_Click(object sender, EventArgs e)
        {
            GenerateQR();
            DisplayQRProperlySized();
        }

        private void GenerateQR()
        {
            if (!String.IsNullOrEmpty(txtTextToUse.Text))
            {
                QRCoder.QRCodeGenerator theQrGenerator = new QRCoder.QRCodeGenerator();
                QRCoder.QRCodeData theQrCodeData = theQrGenerator.CreateQrCode(txtTextToUse.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode theQrCode = new QRCoder.QRCode(theQrCodeData);
                theQrImage = theQrCode.GetGraphic(pixelsPerBlock);
                imgToRender.Visible = true;
                FormText(false);
            }
            else
            {
                imgToRender.Visible = false;
            }
        }

        private void DisplayQRProperlySized()
        {
            if (theQrImage != null)
            {
                var thisSquare = Math.Min(imgToRender.Width, imgToRender.Height);
                if (thisSquare > lastSQuare) { GenerateQR(); } // only need to regenerate when requiring more resolution...
                theQrImage = ResizeImage(theQrImage, thisSquare, thisSquare);
                imgToRender.Image = theQrImage;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DisplayQRProperlySized();
        }

        private void imgToRender_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetImage(imgToRender.Image);
            FormText(true);
        }

        private void FormText(bool Clipboardcopied)
        {
            this.Text = FormTextBase;
            if (Clipboardcopied) { this.Text += "   (image copied to Windows Clipboard)"; }
        }

        // source:https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
