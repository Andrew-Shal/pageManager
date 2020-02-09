namespace PageManager
{
    partial class ImageViewer
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
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.imagePathField = new System.Windows.Forms.TextBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePageBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ImageViewModule = new PageManager.ImagePanel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(166, 41);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(75, 23);
            this.selectImageBtn.TabIndex = 0;
            this.selectImageBtn.Text = "Open Image";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // imagePathField
            // 
            this.imagePathField.Location = new System.Drawing.Point(12, 44);
            this.imagePathField.Name = "imagePathField";
            this.imagePathField.Size = new System.Drawing.Size(148, 20);
            this.imagePathField.TabIndex = 1;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // savePageBtn
            // 
            this.savePageBtn.Location = new System.Drawing.Point(566, 402);
            this.savePageBtn.Name = "savePageBtn";
            this.savePageBtn.Size = new System.Drawing.Size(75, 23);
            this.savePageBtn.TabIndex = 2;
            this.savePageBtn.Text = "Save Page";
            this.savePageBtn.UseVisualStyleBackColor = true;
            this.savePageBtn.Click += new System.EventHandler(this.savePageBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(566, 351);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ImageViewModule
            // 
            this.ImageViewModule.CanvasSize = new System.Drawing.Size(60, 40);
            this.ImageViewModule.Image = null;
            this.ImageViewModule.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.ImageViewModule.Location = new System.Drawing.Point(12, 84);
            this.ImageViewModule.Name = "ImageViewModule";
            this.ImageViewModule.Size = new System.Drawing.Size(726, 260);
            this.ImageViewModule.TabIndex = 3;
            this.ImageViewModule.Zoom = 1F;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ImageViewModule);
            this.Controls.Add(this.savePageBtn);
            this.Controls.Add(this.imagePathField);
            this.Controls.Add(this.selectImageBtn);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.TextBox imagePathField;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button savePageBtn;
        private ImagePanel ImageViewModule;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

