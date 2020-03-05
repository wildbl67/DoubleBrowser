namespace DoubleBrowser
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainerRight = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.treeViewLeft = new System.Windows.Forms.TreeView();
            this.listViewLeft = new System.Windows.Forms.ListView();
            this.treeViewRight = new System.Windows.Forms.TreeView();
            this.listViewRight = new System.Windows.Forms.ListView();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripContainerRight.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainerRight.ContentPanel.SuspendLayout();
            this.toolStripContainerRight.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "folder");
            this.imageListIcons.Images.SetKeyName(1, "document");
            this.imageListIcons.Images.SetKeyName(2, "drive");
            this.imageListIcons.Images.SetKeyName(3, "desktop");
            this.imageListIcons.Images.SetKeyName(4, "music");
            // 
            // toolStripContainerRight
            // 
            this.toolStripContainerRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainerRight.BottomToolStripPanel
            // 
            this.toolStripContainerRight.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainerRight.ContentPanel
            // 
            this.toolStripContainerRight.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainerRight.ContentPanel.Controls.Add(this.splitContainerRight);
            this.toolStripContainerRight.ContentPanel.Controls.Add(this.splitContainerLeft);
            this.toolStripContainerRight.ContentPanel.Size = new System.Drawing.Size(1233, 458);
            this.toolStripContainerRight.Location = new System.Drawing.Point(0, 1);
            this.toolStripContainerRight.Name = "toolStripContainerRight";
            this.toolStripContainerRight.Size = new System.Drawing.Size(1233, 525);
            this.toolStripContainerRight.TabIndex = 0;
            this.toolStripContainerRight.Text = "toolStripContainer1";
            // 
            // toolStripContainerRight.TopToolStripPanel
            // 
            this.toolStripContainerRight.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainerRight.TopToolStripPanel.MinimumSize = new System.Drawing.Size(0, 45);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1233, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(585, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 452);
            this.panel1.TabIndex = 2;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Location = new System.Drawing.Point(644, 7);
            this.splitContainerRight.Name = "splitContainerRight";
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.treeViewRight);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.listViewRight);
            this.splitContainerRight.Size = new System.Drawing.Size(586, 448);
            this.splitContainerRight.SplitterDistance = 195;
            this.splitContainerRight.TabIndex = 1;
            // 
            // treeViewLeft
            // 
            this.treeViewLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeViewLeft.ImageIndex = 0;
            this.treeViewLeft.ImageList = this.imageListIcons;
            this.treeViewLeft.Location = new System.Drawing.Point(3, 4);
            this.treeViewLeft.Name = "treeViewLeft";
            this.treeViewLeft.SelectedImageIndex = 0;
            this.treeViewLeft.Size = new System.Drawing.Size(186, 445);
            this.treeViewLeft.TabIndex = 0;
            // 
            // listViewLeft
            // 
            this.listViewLeft.Location = new System.Drawing.Point(-2, 3);
            this.listViewLeft.Name = "listViewLeft";
            this.listViewLeft.Size = new System.Drawing.Size(376, 446);
            this.listViewLeft.TabIndex = 0;
            this.listViewLeft.UseCompatibleStateImageBehavior = false;
            // 
            // treeViewRight
            // 
            this.treeViewRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeViewRight.ImageIndex = 0;
            this.treeViewRight.ImageList = this.imageListIcons;
            this.treeViewRight.Location = new System.Drawing.Point(3, 0);
            this.treeViewRight.Name = "treeViewRight";
            this.treeViewRight.SelectedImageIndex = 0;
            this.treeViewRight.Size = new System.Drawing.Size(189, 442);
            this.treeViewRight.TabIndex = 0;
            // 
            // listViewRight
            // 
            this.listViewRight.Location = new System.Drawing.Point(3, 3);
            this.listViewRight.Name = "listViewRight";
            this.listViewRight.Size = new System.Drawing.Size(381, 439);
            this.listViewRight.TabIndex = 0;
            this.listViewRight.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerLeft.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLeft.Name = "splitContainerLeft";
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.treeViewLeft);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.listViewLeft);
            this.splitContainerLeft.Size = new System.Drawing.Size(579, 472);
            this.splitContainerLeft.SplitterDistance = 193;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 39);
            this.toolStrip1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 523);
            this.Controls.Add(this.toolStripContainerRight);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStripContainerRight.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainerRight.BottomToolStripPanel.PerformLayout();
            this.toolStripContainerRight.ContentPanel.ResumeLayout(false);
            this.toolStripContainerRight.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerRight.TopToolStripPanel.PerformLayout();
            this.toolStripContainerRight.ResumeLayout(false);
            this.toolStripContainerRight.PerformLayout();
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.ToolStripContainer toolStripContainerRight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.TreeView treeViewLeft;
        private System.Windows.Forms.ListView listViewLeft;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.TreeView treeViewRight;
        private System.Windows.Forms.ListView listViewRight;
        private System.Windows.Forms.Panel panel1;
    }
}

