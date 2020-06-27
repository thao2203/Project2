namespace LapTrinhNangCaoCS
{
    partial class TreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.tvShow = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvShow
            // 
            this.tvShow.ImageIndex = 0;
            this.tvShow.ImageList = this.imageList1;
            this.tvShow.Location = new System.Drawing.Point(13, 13);
            this.tvShow.Name = "tvShow";
            this.tvShow.SelectedImageIndex = 0;
            this.tvShow.Size = new System.Drawing.Size(261, 248);
            this.tvShow.TabIndex = 0;
            this.tvShow.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvShow_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1484686499_Home01.png");
            this.imageList1.Images.SetKeyName(1, "1484686579_Profile01.png");
            this.imageList1.Images.SetKeyName(2, "1484686623_Safety01.png");
            this.imageList1.Images.SetKeyName(3, "1484686525_TrashBin.png");
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 287);
            this.Controls.Add(this.tvShow);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.ImageList imageList1;
    }
}