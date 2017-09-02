namespace ZoomToCursor
{
    partial class ZoomForImageForm
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
            this.pictureEditZoom = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditZoom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEditZoom
            // 
            this.pictureEditZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEditZoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditZoom.EditValue = global::ZoomToCursor.Properties.Resources.ido;
            this.pictureEditZoom.Location = new System.Drawing.Point(12, 12);
            this.pictureEditZoom.Name = "pictureEditZoom";
            this.pictureEditZoom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditZoom.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditZoom.Properties.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureEdit1_Properties_MouseWheel_1);
            this.pictureEditZoom.Size = new System.Drawing.Size(608, 435);
            this.pictureEditZoom.TabIndex = 0;
            this.pictureEditZoom.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureEditZoom_Paint);
            // 
            // ZoomForImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 459);
            this.Controls.Add(this.pictureEditZoom);
            this.Name = "ZoomForImageForm";
            this.Text = "Сделать zoom to cursor для XtraEditors.PictureEdit(Devexpress)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditZoom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditZoom;
    }
}

