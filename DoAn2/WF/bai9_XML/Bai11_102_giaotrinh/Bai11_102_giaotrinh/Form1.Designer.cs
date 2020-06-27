namespace Bai11_102_giaotrinh
{
    partial class Form1
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
            this.btText2XML = new System.Windows.Forms.Button();
            this.btXML2Text = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btText2XML
            // 
            this.btText2XML.Location = new System.Drawing.Point(43, 61);
            this.btText2XML.Name = "btText2XML";
            this.btText2XML.Size = new System.Drawing.Size(204, 44);
            this.btText2XML.TabIndex = 0;
            this.btText2XML.Text = "Text 2 XML";
            this.btText2XML.UseVisualStyleBackColor = true;
            this.btText2XML.Click += new System.EventHandler(this.btText2XML_Click);
            // 
            // btXML2Text
            // 
            this.btXML2Text.Location = new System.Drawing.Point(253, 61);
            this.btXML2Text.Name = "btXML2Text";
            this.btXML2Text.Size = new System.Drawing.Size(199, 44);
            this.btXML2Text.TabIndex = 1;
            this.btXML2Text.Text = "XML 2 Text";
            this.btXML2Text.UseVisualStyleBackColor = true;
            this.btXML2Text.Click += new System.EventHandler(this.btXML2Text_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(377, 115);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 118);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(79, 46);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(426, 34);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(79, 46);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 201);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btXML2Text);
            this.Controls.Add(this.btText2XML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btText2XML;
        private System.Windows.Forms.Button btXML2Text;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

