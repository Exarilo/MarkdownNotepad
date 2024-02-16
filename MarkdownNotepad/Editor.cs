using Markdig;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MarkdownNotepad
{
    public partial class Editor : Form
    {
        private Dictionary<List<Keys>, Action> Shortcut_Actions;
        private Dictionary<Button, Action> UI_Actions;
       
        public Editor()
        {
            InitializeComponent();
            InitializeUIEvents();
            InitializeShortcutEvents();
            tabControlEditor.AddNewPage();

            this.KeyDown += Form_KeyDown;
        }

        private void InitializeShortcutEvents()
        {
            Shortcut_Actions = new Dictionary<List<Keys>, Action>
            {
                { new List<Keys> { Keys.Control, Keys.B }, () => tabControlEditor.SelectedTab.SurroundSelectedText("**", "**") },
                { new List<Keys> { Keys.Control,Keys.U }, () => tabControlEditor.SelectedTab.SurroundSelectedText("<u>", "</u>") },
                { new List<Keys> { Keys.Control, Keys.G }, () => tabControlEditor.SelectedTab.SurroundSelectedText("**", "**") },
                { new List<Keys> { Keys.Control,Keys.S }, () => tabControlEditor.SaveCurrentPage()},
                { new List<Keys> { Keys.Control, Keys.O }, () => tabControlEditor.OpenFileInNewPage() },
                { new List<Keys> { Keys.Control, Keys.I}, () => tabControlEditor.SelectedTab.SurroundSelectedText("*", "*") },
                { new List<Keys> { Keys.Control,Keys.N }, () => tabControlEditor.AddNewPage()},
                { new List<Keys> { Keys.Control,Keys.T }, () => tabControlEditor.SelectedTab.AddTextAtLineStart("# ") },
                { new List<Keys> { Keys.Control,Keys.D1 }, () => tabControlEditor.SelectedTab.AddTextAtLineStart("# ") },
                { new List<Keys> { Keys.Control,Keys.D2 }, () => tabControlEditor.SelectedTab.AddTextAtLineStart("## ") },
                { new List<Keys> { Keys.F7 }, () => ShowMarkdownPreview() },
            };
        }

        private void ShowMarkdownPreview()
        {
            webBrowserPreview.Visible = !webBrowserPreview.Visible;
            tabControlEditor.Visible = !webBrowserPreview.Visible;
            if (webBrowserPreview.Visible)
            {
                var markdown = tabControlEditor.SelectedTab.Controls.OfType<RichTextBox>().First().Text;
                var html = Markdown.ToHtml(markdown);
                webBrowserPreview.DocumentText = html;
                webBrowserPreview.Visible = true;
                tabControlEditor.Visible = false;
            }
        }

        private void InitializeUIEvents()
        {
            UI_Actions = new Dictionary<Button, Action>
            {
                { bt_ToBold, () =>  tabControlEditor.SelectedTab.SurroundSelectedText("**", "**")},
                { bt_ToItalic, () => tabControlEditor.SelectedTab.SurroundSelectedText("*", "*")},
                { bt_ToUnderlined, () => tabControlEditor.SelectedTab.SurroundSelectedText("<u>", "</u>")},
                { bt_ToTitle1, () =>  tabControlEditor.SelectedTab.AddTextAtLineStart("#") },
                { bt_ToTitle2, () =>  tabControlEditor.SelectedTab.AddTextAtLineStart("##") },
            };
                

            UI_Actions.Keys?.ToList().ForEach(bt => bt.Click += (s, e) => UI_Actions[bt]());

            newPageToolStripMenuItem.Click += (s, e) => { tabControlEditor.AddNewPage(); };
            saveToolStripMenuItem.Click += (s, e) => { tabControlEditor.SaveCurrentPage(); };
            saveAsToolStripMenuItem.Click += (s, e) => { tabControlEditor.SaveAsCurrentPage(); };
            openToolStripMenuItem.Click += (s, e) => { tabControlEditor.OpenFileInNewPage(); };
            
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5) //it can't work due to webroser inherent shortcut
            {
                e.SuppressKeyPress = true;
                return;
            }

            foreach (var shortcut in Shortcut_Actions)
            {
                if (shortcut.Key.All(k => (k == Keys.Control ? e.Control : e.KeyCode == k)))
                {
                    shortcut.Value();
                    e.SuppressKeyPress = true;
                    break;
                }
            }
        }
    }
}
