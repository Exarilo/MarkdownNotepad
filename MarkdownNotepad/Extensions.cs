using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace MarkdownNotepad
{
    public static class StringExtensions
    {
        public static void SurroundSelectedText(this TabPage currentPage, string txt1,string txt2){;
            RichTextBox currEditor = currentPage.Controls.OfType<RichTextBox>()?.FirstOrDefault();
            if (currEditor == null) { return; }

            string selectedText = currEditor.SelectedText;
            if (!string.IsNullOrEmpty(selectedText))
            {
                currEditor.SelectedText = txt1 + selectedText + txt2;
            }
        }

        public static void AddTextAtLineStart(this TabPage currentPage, string textToAdd)
        {
            RichTextBox currEditor = currentPage.Controls.OfType<RichTextBox>()?.FirstOrDefault();
            if (currEditor == null) { return; }

            int cursorPosition = currEditor.SelectionStart;

            int lineIndex = currEditor.GetFirstCharIndexOfCurrentLine();
            currEditor.Text = currEditor.Text.Insert(lineIndex, textToAdd);

            currEditor.SelectionStart = cursorPosition + textToAdd.Length;
        }
    }

    public static class TabControlExtensions
    {
        public static void AddNewPage(this TabControl tabControl)
        {
            TabPage newTabPage = new TabPage($"Untitled-{tabControl.TabPages.Cast<TabPage>().Count(page => page.Tag == null) + 1}");
            RichTextBox textBox = new RichTextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(textBox);

            tabControl.TabPages.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;
        }
        public static void SaveCurrentPage(this TabControl tabControl)
        {
            TabPage curPage = tabControl.SelectedTab;
            if(curPage == null || !File.Exists((string)curPage.Tag))
            {
                tabControl.SaveAsCurrentPage();
                return;
            }

            RichTextBox currEditor = curPage.Controls.OfType<RichTextBox>()?.FirstOrDefault();
            File.WriteAllText((string)curPage.Tag, currEditor.Text);
        }

        public static void SaveAsCurrentPage(this TabControl tabControl)
        {
            TabPage curPage = tabControl.SelectedTab;
            RichTextBox currEditor = curPage.Controls.OfType<RichTextBox>()?.FirstOrDefault();
            if (currEditor == null) { return; }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Markdown Files (*.md)|*.md|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, currEditor.Text);
                curPage.Text = Path.GetFileName(saveFileDialog.FileName);
                curPage.Tag = saveFileDialog.FileName;
            }
        }

        public static void OpenFileInNewPage(this TabControl tabControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt|Markdown Files (*.md)|*.md";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(openFileDialog.FileName);

                TabPage newTabPage = new TabPage(Path.GetFileName(openFileDialog.FileName));
                RichTextBox textBox = new RichTextBox();
                textBox.Multiline = true;
                textBox.Dock = DockStyle.Fill;
                textBox.Text = fileContent;
                newTabPage.Controls.Add(textBox);

                newTabPage.Tag = openFileDialog.FileName;

                tabControl.TabPages.Add(newTabPage);
                tabControl.SelectedTab = newTabPage;
            }
        }
    }
}
