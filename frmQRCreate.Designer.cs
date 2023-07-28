
namespace QRCreate
{
    partial class QRCreate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRender = new System.Windows.Forms.Button();
            this.txtTextToUse = new System.Windows.Forms.TextBox();
            this.imgToRender = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgToRender)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(12, 12);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 23);
            this.btnRender.TabIndex = 1;
            this.btnRender.Text = "QR this!";
            this.toolTip2.SetToolTip(this.btnRender, "Click on image below to copy image to clipboard");
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // txtTextToUse
            // 
            this.txtTextToUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToUse.Location = new System.Drawing.Point(93, 13);
            this.txtTextToUse.Name = "txtTextToUse";
            this.txtTextToUse.Size = new System.Drawing.Size(686, 23);
            this.txtTextToUse.TabIndex = 2;
            this.toolTip2.SetToolTip(this.txtTextToUse, "Click on image below to copy to windows clipboard..");
            // 
            // imgToRender
            // 
            this.imgToRender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgToRender.Location = new System.Drawing.Point(12, 41);
            this.imgToRender.Name = "imgToRender";
            this.imgToRender.Size = new System.Drawing.Size(768, 604);
            this.imgToRender.TabIndex = 3;
            this.imgToRender.TabStop = false;
            this.imgToRender.Visible = false;
            this.imgToRender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgToRender_MouseClick);
            // 
            // QRCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 657);
            this.Controls.Add(this.imgToRender);
            this.Controls.Add(this.txtTextToUse);
            this.Controls.Add(this.btnRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "QRCreate";
            this.Text = "QR Create";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgToRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.TextBox txtTextToUse;
        private System.Windows.Forms.PictureBox imgToRender;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

