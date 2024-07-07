namespace SilkyPainter
{
    partial class MainForm
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
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            AssetsLibrary = new TabControl();
            MaterialsTab = new TabPage();
            SmartMaterialsTab = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            SceneView = new OpenTK.WinForms.GLControl();
            TextureView = new OpenTK.WinForms.GLControl();
            BrushesTab = new TabPage();
            AlphasTab = new TabPage();
            TexturesTab = new TabPage();
            EnvMapTab = new TabPage();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            MaterialList = new ListView();
            SMaterialList = new ListView();
            BrushesList = new ListView();
            AlphasList = new ListView();
            TexturesList = new ListView();
            EnvMapsList = new ListView();
            menuStrip1.SuspendLayout();
            AssetsLibrary.SuspendLayout();
            MaterialsTab.SuspendLayout();
            SmartMaterialsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            BrushesTab.SuspendLayout();
            AlphasTab.SuspendLayout();
            TexturesTab.SuspendLayout();
            EnvMapTab.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 659);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1264, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // AssetsLibrary
            // 
            AssetsLibrary.Controls.Add(MaterialsTab);
            AssetsLibrary.Controls.Add(SmartMaterialsTab);
            AssetsLibrary.Controls.Add(BrushesTab);
            AssetsLibrary.Controls.Add(AlphasTab);
            AssetsLibrary.Controls.Add(TexturesTab);
            AssetsLibrary.Controls.Add(EnvMapTab);
            AssetsLibrary.Dock = DockStyle.Left;
            AssetsLibrary.HotTrack = true;
            AssetsLibrary.Location = new Point(0, 49);
            AssetsLibrary.Name = "AssetsLibrary";
            AssetsLibrary.SelectedIndex = 0;
            AssetsLibrary.Size = new Size(200, 610);
            AssetsLibrary.TabIndex = 3;
            // 
            // MaterialsTab
            // 
            MaterialsTab.Controls.Add(MaterialList);
            MaterialsTab.Location = new Point(4, 24);
            MaterialsTab.Name = "MaterialsTab";
            MaterialsTab.Padding = new Padding(3);
            MaterialsTab.Size = new Size(192, 582);
            MaterialsTab.TabIndex = 0;
            MaterialsTab.Text = "Materials";
            MaterialsTab.UseVisualStyleBackColor = true;
            // 
            // SmartMaterialsTab
            // 
            SmartMaterialsTab.Controls.Add(SMaterialList);
            SmartMaterialsTab.Location = new Point(4, 24);
            SmartMaterialsTab.Name = "SmartMaterialsTab";
            SmartMaterialsTab.Padding = new Padding(3);
            SmartMaterialsTab.Size = new Size(192, 582);
            SmartMaterialsTab.TabIndex = 1;
            SmartMaterialsTab.Text = "Smart Materials";
            SmartMaterialsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Right;
            splitContainer1.Location = new Point(1067, 49);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(197, 610);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(200, 49);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(SceneView);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(TextureView);
            splitContainer2.Size = new Size(867, 610);
            splitContainer2.SplitterDistance = 431;
            splitContainer2.TabIndex = 5;
            // 
            // SceneView
            // 
            SceneView.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            SceneView.APIVersion = new Version(3, 3, 0, 0);
            SceneView.Dock = DockStyle.Fill;
            SceneView.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            SceneView.IsEventDriven = true;
            SceneView.Location = new Point(0, 0);
            SceneView.Name = "SceneView";
            SceneView.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
            SceneView.Size = new Size(431, 610);
            SceneView.TabIndex = 0;
            SceneView.Text = "glControl1";
            // 
            // TextureView
            // 
            TextureView.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            TextureView.APIVersion = new Version(3, 3, 0, 0);
            TextureView.Dock = DockStyle.Fill;
            TextureView.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            TextureView.IsEventDriven = true;
            TextureView.Location = new Point(0, 0);
            TextureView.Name = "TextureView";
            TextureView.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
            TextureView.Size = new Size(432, 610);
            TextureView.TabIndex = 0;
            TextureView.Text = "glControl1";
            // 
            // BrushesTab
            // 
            BrushesTab.Controls.Add(BrushesList);
            BrushesTab.Location = new Point(4, 24);
            BrushesTab.Name = "BrushesTab";
            BrushesTab.Size = new Size(192, 582);
            BrushesTab.TabIndex = 2;
            BrushesTab.Text = "Brushes";
            BrushesTab.UseVisualStyleBackColor = true;
            // 
            // AlphasTab
            // 
            AlphasTab.Controls.Add(AlphasList);
            AlphasTab.Location = new Point(4, 24);
            AlphasTab.Name = "AlphasTab";
            AlphasTab.Size = new Size(192, 582);
            AlphasTab.TabIndex = 3;
            AlphasTab.Text = "Alphas";
            AlphasTab.UseVisualStyleBackColor = true;
            // 
            // TexturesTab
            // 
            TexturesTab.Controls.Add(TexturesList);
            TexturesTab.Location = new Point(4, 24);
            TexturesTab.Name = "TexturesTab";
            TexturesTab.Size = new Size(192, 582);
            TexturesTab.TabIndex = 4;
            TexturesTab.Text = "Textures";
            TexturesTab.UseVisualStyleBackColor = true;
            // 
            // EnvMapTab
            // 
            EnvMapTab.Controls.Add(EnvMapsList);
            EnvMapTab.Location = new Point(4, 24);
            EnvMapTab.Name = "EnvMapTab";
            EnvMapTab.Size = new Size(192, 582);
            EnvMapTab.TabIndex = 5;
            EnvMapTab.Text = "Environment Maps";
            EnvMapTab.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, importToolStripMenuItem, exportToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // MaterialList
            // 
            MaterialList.Dock = DockStyle.Fill;
            MaterialList.Location = new Point(3, 3);
            MaterialList.Name = "MaterialList";
            MaterialList.Size = new Size(186, 576);
            MaterialList.TabIndex = 0;
            MaterialList.UseCompatibleStateImageBehavior = false;
            // 
            // SMaterialList
            // 
            SMaterialList.Dock = DockStyle.Fill;
            SMaterialList.Location = new Point(3, 3);
            SMaterialList.Name = "SMaterialList";
            SMaterialList.Size = new Size(186, 576);
            SMaterialList.TabIndex = 0;
            SMaterialList.UseCompatibleStateImageBehavior = false;
            // 
            // BrushesList
            // 
            BrushesList.Dock = DockStyle.Fill;
            BrushesList.Location = new Point(0, 0);
            BrushesList.Name = "BrushesList";
            BrushesList.Size = new Size(192, 582);
            BrushesList.TabIndex = 0;
            BrushesList.UseCompatibleStateImageBehavior = false;
            // 
            // AlphasList
            // 
            AlphasList.Dock = DockStyle.Fill;
            AlphasList.Location = new Point(0, 0);
            AlphasList.Name = "AlphasList";
            AlphasList.Size = new Size(192, 582);
            AlphasList.TabIndex = 0;
            AlphasList.UseCompatibleStateImageBehavior = false;
            // 
            // TexturesList
            // 
            TexturesList.Dock = DockStyle.Fill;
            TexturesList.Location = new Point(0, 0);
            TexturesList.Name = "TexturesList";
            TexturesList.Size = new Size(192, 582);
            TexturesList.TabIndex = 0;
            TexturesList.UseCompatibleStateImageBehavior = false;
            // 
            // EnvMapsList
            // 
            EnvMapsList.Dock = DockStyle.Fill;
            EnvMapsList.Location = new Point(0, 0);
            EnvMapsList.Name = "EnvMapsList";
            EnvMapsList.Size = new Size(192, 582);
            EnvMapsList.TabIndex = 0;
            EnvMapsList.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Controls.Add(AssetsLibrary);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Silky Painter";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            AssetsLibrary.ResumeLayout(false);
            MaterialsTab.ResumeLayout(false);
            SmartMaterialsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            BrushesTab.ResumeLayout(false);
            AlphasTab.ResumeLayout(false);
            TexturesTab.ResumeLayout(false);
            EnvMapTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private TabControl AssetsLibrary;
        private TabPage MaterialsTab;
        private TabPage SmartMaterialsTab;
        private TabPage BrushesTab;
        private TabPage AlphasTab;
        private TabPage TexturesTab;
        private TabPage EnvMapTab;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private OpenTK.WinForms.GLControl SceneView;
        private OpenTK.WinForms.GLControl TextureView;
        private ListView MaterialList;
        private ListView SMaterialList;
        private ListView BrushesList;
        private ListView AlphasList;
        private ListView TexturesList;
        private ListView EnvMapsList;
    }
}