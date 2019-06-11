using RandomFileOpener.Control;
using System;
using System.Windows.Forms;

namespace RandomFileOpener.View
{
    public partial class OptionsWindows:Form
    {
        public OptionsWindows() => this.InitializeComponent();

        // Load latest saved setting on load
        private void OptionsWindows_Load(object sender, EventArgs e)
        {

            this.SearchSubdirOffRdb.Checked = !OptionsManager.SearchSubDir;
            this.SearchSubdirOnRdb.Checked = OptionsManager.SearchSubDir;

            this.SearchUniqueOffRdb.Checked = !OptionsManager.SearchUnique;
            this.SearchUniqueOnRdb.Checked = OptionsManager.SearchUnique;

            this.filterFormatTbx.Text = OptionsManager.ValidFileExtentions;

            this.MovePathTbox1.Text = OptionsManager.MovePath1;
            this.MovePathTbox2.Text = OptionsManager.MovePath2;
        }

        // Save setting
        private void OptionsOKBtn_Click(object sender, EventArgs e)
        {
            OptionsManager.SearchUnique = this.SearchUniqueOnRdb.Checked;
            OptionsManager.SearchSubDir = this.SearchSubdirOnRdb.Checked;
            OptionsManager.ValidFileExtentions = this.filterFormatTbx.Text;
            OptionsManager.MovePath1 = this.MovePathTbox1.Text;
            OptionsManager.MovePath2 = this.MovePathTbox2.Text;
            this.Close();
        }

        private void Path1BrowserBtn_Click(object sender, EventArgs e)
        {
            this.MovePathTbox1.Text = ActionManager.GetDirectoryPath(this.MovePathTbox1.Text);
        }

        private void Path2BrowserBtn_Click(object sender, EventArgs e)
        {
            this.MovePathTbox2.Text = ActionManager.GetDirectoryPath(this.MovePathTbox2.Text);
        }
    }
}
