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

            this.SearchSubdirOffRdb.Checked = !OptionsManager.Instance.SearchSubDir;
            this.SearchSubdirOnRdb.Checked = OptionsManager.Instance.SearchSubDir;

            this.SearchUniqueOffRdb.Checked = !OptionsManager.Instance.SearchUnique;
            this.SearchUniqueOnRdb.Checked = OptionsManager.Instance.SearchUnique;

            this.InstantOpenOffRdb.Checked = !OptionsManager.Instance.InstantOpen;
            this.InstantOpenOnRdb.Checked = OptionsManager.Instance.InstantOpen;

            this.filterFormatTbx.Text = OptionsManager.Instance.ValidFileExtentions;

            this.MovePathTbox1.Text = OptionsManager.Instance.MovePath1;
            this.MovePathTbox2.Text = OptionsManager.Instance.MovePath2;
        }

        // Save setting
        private void OptionsOKBtn_Click(object sender, EventArgs e)
        {
            OptionsManager.Instance.SearchUnique = this.SearchUniqueOnRdb.Checked;
            OptionsManager.Instance.SearchSubDir = this.SearchSubdirOnRdb.Checked;
            OptionsManager.Instance.InstantOpen = this.InstantOpenOnRdb.Checked;
            OptionsManager.Instance.ValidFileExtentions = this.filterFormatTbx.Text;
            OptionsManager.Instance.MovePath1 = this.MovePathTbox1.Text;
            OptionsManager.Instance.MovePath2 = this.MovePathTbox2.Text;
            this.Close();
        }

        private void Path1BrowserBtn_Click(object sender, EventArgs e)
            => this.MovePathTbox1.Text = ActionManager.GetDirectoryPath(this.MovePathTbox1.Text);
        

        private void Path2BrowserBtn_Click(object sender, EventArgs e)
            => this.MovePathTbox2.Text = ActionManager.GetDirectoryPath(this.MovePathTbox2.Text);
    }
}
