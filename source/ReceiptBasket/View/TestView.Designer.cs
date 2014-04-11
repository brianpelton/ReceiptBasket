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
            this.chkOptimize = new Telerik.WinControls.UI.RadCheckBox();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOptimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
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
            this.imgViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgViewer.Location = new System.Drawing.Point(128, 12);
            this.imgViewer.Name = "imgViewer";
            this.imgViewer.Size = new System.Drawing.Size(444, 413);
            this.imgViewer.TabIndex = 1;
            // 
            // chkOptimize
            // 
            this.chkOptimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOptimize.Location = new System.Drawing.Point(128, 431);
            this.chkOptimize.Name = "chkOptimize";
            this.chkOptimize.Size = new System.Drawing.Size(66, 18);
            this.chkOptimize.TabIndex = 2;
            this.chkOptimize.Text = "Optimize";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.LargeTickFrequency = 50;
            this.radTrackBar1.Location = new System.Drawing.Point(12, 42);
            this.radTrackBar1.Maximum = 250F;
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(110, 37);
            this.radTrackBar1.SmallTickFrequency = 10;
            this.radTrackBar1.TabIndex = 3;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.Value = 95F;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.radTrackBar1);
            this.Controls.Add(this.chkOptimize);
            this.Controls.Add(this.imgViewer);
            this.Controls.Add(this.cmdOpenImage);
            this.Name = "TestView";
            this.Text = "TestView";
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOptimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton cmdOpenImage;
        private Cyotek.Windows.Forms.ImageBox imgViewer;
        private Telerik.WinControls.UI.RadCheckBox chkOptimize;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    }
}