namespace MarkdownNotepad
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ToTitle2 = new System.Windows.Forms.Button();
            this.bt_ToTitle1 = new System.Windows.Forms.Button();
            this.bt_ToUnderlined = new System.Windows.Forms.Button();
            this.bt_ToItalic = new System.Windows.Forms.Button();
            this.bt_ToBold = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
            this.tabControlEditor = new MarkdownNotepad.DraggableTabControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.newPageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.newPageToolStripMenuItem.Text = "New Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_ToTitle2);
            this.panel1.Controls.Add(this.bt_ToTitle1);
            this.panel1.Controls.Add(this.bt_ToUnderlined);
            this.panel1.Controls.Add(this.bt_ToItalic);
            this.panel1.Controls.Add(this.bt_ToBold);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 426);
            this.panel1.TabIndex = 3;
            // 
            // bt_ToTitle2
            // 
            this.bt_ToTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ToTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ToTitle2.Location = new System.Drawing.Point(0, 112);
            this.bt_ToTitle2.Name = "bt_ToTitle2";
            this.bt_ToTitle2.Size = new System.Drawing.Size(40, 28);
            this.bt_ToTitle2.TabIndex = 9;
            this.bt_ToTitle2.Text = "T-2";
            this.bt_ToTitle2.UseVisualStyleBackColor = true;
            // 
            // bt_ToTitle1
            // 
            this.bt_ToTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ToTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ToTitle1.Location = new System.Drawing.Point(0, 84);
            this.bt_ToTitle1.Name = "bt_ToTitle1";
            this.bt_ToTitle1.Size = new System.Drawing.Size(40, 28);
            this.bt_ToTitle1.TabIndex = 8;
            this.bt_ToTitle1.Text = "T-1";
            this.bt_ToTitle1.UseVisualStyleBackColor = true;
            // 
            // bt_ToUnderlined
            // 
            this.bt_ToUnderlined.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ToUnderlined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ToUnderlined.Location = new System.Drawing.Point(0, 56);
            this.bt_ToUnderlined.Name = "bt_ToUnderlined";
            this.bt_ToUnderlined.Size = new System.Drawing.Size(40, 28);
            this.bt_ToUnderlined.TabIndex = 7;
            this.bt_ToUnderlined.Text = "U";
            this.bt_ToUnderlined.UseVisualStyleBackColor = true;
            // 
            // bt_ToItalic
            // 
            this.bt_ToItalic.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ToItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ToItalic.Location = new System.Drawing.Point(0, 28);
            this.bt_ToItalic.Name = "bt_ToItalic";
            this.bt_ToItalic.Size = new System.Drawing.Size(40, 28);
            this.bt_ToItalic.TabIndex = 6;
            this.bt_ToItalic.Text = "I";
            this.bt_ToItalic.UseVisualStyleBackColor = true;
            // 
            // bt_ToBold
            // 
            this.bt_ToBold.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ToBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ToBold.Location = new System.Drawing.Point(0, 0);
            this.bt_ToBold.Name = "bt_ToBold";
            this.bt_ToBold.Size = new System.Drawing.Size(40, 28);
            this.bt_ToBold.TabIndex = 5;
            this.bt_ToBold.Text = "B";
            this.bt_ToBold.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControlEditor);
            this.panel2.Controls.Add(this.webBrowserPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(44, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 426);
            this.panel2.TabIndex = 5;
            // 
            // webBrowserPreview
            // 
            this.webBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPreview.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreview.Name = "webBrowserPreview";
            this.webBrowserPreview.Size = new System.Drawing.Size(754, 424);
            this.webBrowserPreview.TabIndex = 6;
            this.webBrowserPreview.Visible = false;
            // 
            // tabControlEditor
            // 
            this.tabControlEditor.AllowDrop = true;
            this.tabControlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEditor.Location = new System.Drawing.Point(0, 0);
            this.tabControlEditor.Name = "tabControlEditor";
            this.tabControlEditor.SelectedIndex = 0;
            this.tabControlEditor.Size = new System.Drawing.Size(754, 424);
            this.tabControlEditor.TabIndex = 5;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Markdown Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_ToItalic;
        private System.Windows.Forms.Button bt_ToBold;
        private System.Windows.Forms.Button bt_ToTitle2;
        private System.Windows.Forms.Button bt_ToTitle1;
        private System.Windows.Forms.Button bt_ToUnderlined;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private DraggableTabControl tabControlEditor;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
    }
}

