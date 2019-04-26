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
        }

        // Save setting
        private void OptionsOKBtn_Click(object sender, EventArgs e)
        {
            OptionsManager.SearchUnique = this.SearchUniqueOnRdb.Checked;
            OptionsManager.SearchSubDir = this.SearchSubdirOnRdb.Checked;
            OptionsManager.ValidFileExtentions = this.filterFormatTbx.Text;
            this.Close();
        }
    }
}
