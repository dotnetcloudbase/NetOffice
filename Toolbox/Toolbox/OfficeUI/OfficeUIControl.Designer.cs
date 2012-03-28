﻿namespace NetOffice.DeveloperToolbox
{
    partial class OfficeUIControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeUIControl));
            this.contextMenuTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCloseOfficeApp = new System.Windows.Forms.Button();
            this.checkBoxScanForProperties = new System.Windows.Forms.CheckBox();
            this.propertyGridItems = new System.Windows.Forms.PropertyGrid();
            this.buttonStartApplication = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.treeViewOfficeUI = new NetOffice.DeveloperToolbox.MultiSelectTreeView();
            this.contextMenuTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuTreeView
            // 
            this.contextMenuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripReset,
            this.toolStripDelete});
            this.contextMenuTreeView.Name = "contextMenuStrip1";
            this.contextMenuTreeView.Size = new System.Drawing.Size(117, 48);
            // 
            // toolStripReset
            // 
            this.toolStripReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReset.Image")));
            this.toolStripReset.Name = "toolStripReset";
            this.toolStripReset.Size = new System.Drawing.Size(116, 22);
            this.toolStripReset.Text = "Reset";
            this.toolStripReset.Click += new System.EventHandler(this.toolStripReset_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(116, 22);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeView.Images.SetKeyName(0, "bar.png");
            this.imageListTreeView.Images.SetKeyName(1, "button.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewOfficeUI);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCloseOfficeApp);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxScanForProperties);
            this.splitContainer1.Panel2.Controls.Add(this.propertyGridItems);
            this.splitContainer1.Size = new System.Drawing.Size(797, 374);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonCloseOfficeApp
            // 
            this.buttonCloseOfficeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseOfficeApp.Enabled = false;
            this.buttonCloseOfficeApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseOfficeApp.Image")));
            this.buttonCloseOfficeApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCloseOfficeApp.Location = new System.Drawing.Point(398, 349);
            this.buttonCloseOfficeApp.Name = "buttonCloseOfficeApp";
            this.buttonCloseOfficeApp.Size = new System.Drawing.Size(189, 25);
            this.buttonCloseOfficeApp.TabIndex = 4;
            this.buttonCloseOfficeApp.Text = "Office Anwendung schliessen";
            this.buttonCloseOfficeApp.UseVisualStyleBackColor = true;
            this.buttonCloseOfficeApp.Click += new System.EventHandler(this.buttonCloseOfficeApp_Click);
            // 
            // checkBoxScanForProperties
            // 
            this.checkBoxScanForProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxScanForProperties.AutoSize = true;
            this.checkBoxScanForProperties.Location = new System.Drawing.Point(3, 354);
            this.checkBoxScanForProperties.Name = "checkBoxScanForProperties";
            this.checkBoxScanForProperties.Size = new System.Drawing.Size(133, 17);
            this.checkBoxScanForProperties.TabIndex = 1;
            this.checkBoxScanForProperties.Text = "Eigenschaften abrufen";
            this.checkBoxScanForProperties.UseVisualStyleBackColor = true;
            // 
            // propertyGridItems
            // 
            this.propertyGridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridItems.Location = new System.Drawing.Point(2, 2);
            this.propertyGridItems.Name = "propertyGridItems";
            this.propertyGridItems.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGridItems.Size = new System.Drawing.Size(585, 346);
            this.propertyGridItems.TabIndex = 0;
            this.propertyGridItems.ToolbarVisible = false;
            // 
            // buttonStartApplication
            // 
            this.buttonStartApplication.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartApplication.Image")));
            this.buttonStartApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartApplication.Location = new System.Drawing.Point(12, 11);
            this.buttonStartApplication.Name = "buttonStartApplication";
            this.buttonStartApplication.Size = new System.Drawing.Size(193, 29);
            this.buttonStartApplication.TabIndex = 3;
            this.buttonStartApplication.Text = "Anwendung auswählen";
            this.buttonStartApplication.UseVisualStyleBackColor = true;
            this.buttonStartApplication.Click += new System.EventHandler(this.buttonStartApplication_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.pictureBox5);
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(219, 16);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(514, 24);
            this.panelInfo.TabIndex = 75;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(20, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelInfo.Location = new System.Drawing.Point(42, 7);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(381, 13);
            this.labelInfo.TabIndex = 72;
            this.labelInfo.Text = "Nutzen Sie das Kontextmenü in der linken Übersicht um Elemente zu entfernen.";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(753, 10);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(28, 28);
            this.buttonInfo.TabIndex = 76;
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // treeViewOfficeUI
            // 
            this.treeViewOfficeUI.ContextMenuStrip = this.contextMenuTreeView;
            this.treeViewOfficeUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOfficeUI.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeViewOfficeUI.HideSelection = false;
            this.treeViewOfficeUI.ImageIndex = 0;
            this.treeViewOfficeUI.ImageList = this.imageListTreeView;
            this.treeViewOfficeUI.Location = new System.Drawing.Point(0, 0);
            this.treeViewOfficeUI.Name = "treeViewOfficeUI";
            this.treeViewOfficeUI.SelectedImageIndex = 0;
            this.treeViewOfficeUI.SelectedNodes = ((System.Collections.Generic.List<System.Windows.Forms.TreeNode>)(resources.GetObject("treeViewOfficeUI.SelectedNodes")));
            this.treeViewOfficeUI.Size = new System.Drawing.Size(203, 374);
            this.treeViewOfficeUI.TabIndex = 1;
            this.treeViewOfficeUI.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewOfficeUI_BeforeExpand);
            this.treeViewOfficeUI.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOfficeUI_AfterSelect);
            // 
            // OfficeUIControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonStartApplication);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OfficeUIControl";
            this.Size = new System.Drawing.Size(800, 429);
            this.contextMenuTreeView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGridItems;
        private System.Windows.Forms.ContextMenuStrip contextMenuTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolStripReset;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelete;
        private System.Windows.Forms.Button buttonStartApplication;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.ImageList imageListTreeView;
        private System.Windows.Forms.CheckBox checkBoxScanForProperties;
        private System.Windows.Forms.Button buttonCloseOfficeApp;
        private MultiSelectTreeView treeViewOfficeUI;
    }
}
