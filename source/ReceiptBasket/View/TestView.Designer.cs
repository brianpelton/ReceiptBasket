namespace ReceiptBasket.View
{
    partial class TestView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOpenImage = new Telerik.WinControls.UI.RadButton();
            this.imgViewer = new Cyotek.Windows.Forms.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOpenImage
            // 
            this.cmdOpenImage.Location = new System.Drawing.Point(12, 12);
            this.cmdOpenImage.Name = "cmdOpenImage";
            this.cmdOpenImage.Size = new System.Drawing.Size(110, 24);
            this.cmdOpenImage.TabIndex = 0;
            this.cmdOpenImage.Text = "Open";
            this.cmdOpenImage.Click += new System.EventHandler(this.cmdOpenImage_Click);
            // 
            // imgViewer
            // 
            this.imgViewer.Location = new System.Drawing.Point(128, 12);
            this.imgViewer.Name = "imgViewer";
            this.imgViewer.Size = new System.Drawing.Size(377, 321);
            this.imgViewer.TabIndex = 1;
            this.imgViewer.Text = "imageBox1";
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 345);
            this.Controls.Add(this.imgViewer);
            this.Controls.Add(this.cmdOpenImage);
            this.Name = "TestView";
            this.Text = "TestView";
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton cmdOpenImage;
        private Cyotek.Windows.Forms.ImageBox imgViewer;
    }
}