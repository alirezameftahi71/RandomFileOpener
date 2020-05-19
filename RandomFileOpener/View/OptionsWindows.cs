using RandomFileOpener.Control;
using System;
using System.Windows.Forms;

namespace RandomFileOpener.View
{
    public partial class OptionsWindows : Form
    {
        private MainWindow mainWindow;

        public OptionsWindows(Form mainWindow)
        {
            this.mainWindow = mainWindow as MainWindow;
            this.InitializeComponent();
        }

        // Load latest saved setting on load
        private void OptionsWindows_Load(object sender, EventArgs e)
        {

            this.SearchSubdirOffRdb.Checked = !OptionsManager.Instance.SearchSubDir;
            this.SearchSubdirOnRdb.Checked = OptionsManager.Instance.SearchSubDir;

            this.SearchUniqueOffRdb.Checked = !OptionsManager.Instance.SearchUnique;
            this.SearchUniqueOnRdb.Checked = OptionsManager.Instance.SearchUnique;

            this.InstantOpenOffRdb.Checked = !OptionsManager.Instance.InstantOpen;
            this.InstantOpenOnRdb.Checked = OptionsManager.Instance.InstantOpen;

            this.FilterFormatTbx.Text = OptionsManager.Instance.ValidFileExtentions;

            this.MovePathLabel1.Text = OptionsManager.Instance.MovePath1;
            this.MovePathLabel2.Text = OptionsManager.Instance.MovePath2;

            this.MovePathTbox1.Text = OptionsManager.Instance.MovePathName1;
            this.MovePathTbox2.Text = OptionsManager.Instance.MovePathName2;

            this.ShowInfoMsgOffRdb.Checked = !OptionsManager.Instance.ShowInformationMessages;
            this.ShowInfoMsgOnRdb.Checked = OptionsManager.Instance.ShowInformationMessages;
        }

        // Save setting
        private void OptionsOKBtn_Click(object sender, EventArgs e)
        {
            OptionsManager.Instance.SearchUnique = this.SearchUniqueOnRdb.Checked;
            OptionsManager.Instance.SearchSubDir = this.SearchSubdirOnRdb.Checked;
            OptionsManager.Instance.InstantOpen = this.InstantOpenOnRdb.Checked;
            OptionsManager.Instance.ValidFileExtentions = this.FilterFormatTbx.Text;
            OptionsManager.Instance.MovePath1 = this.MovePathLabel1.Text;
            OptionsManager.Instance.MovePath2 = this.MovePathLabel2.Text;
            OptionsManager.Instance.MovePathName1 = this.MovePathTbox1.Text;
            OptionsManager.Instance.MovePathName2 = this.MovePathTbox2.Text;
            OptionsManager.Instance.ShowInformationMessages = this.ShowInfoMsgOnRdb.Checked;
            this.mainWindow.UpdateMoveToPathButtonsLabel();
            this.Dispose();
        }

        private void Path1BrowserBtn_Click(object sender, EventArgs e)
            => this.MovePathLabel1.Text = ActionManager.GetDirectoryPath(this.MovePathLabel1.Text);


        private void Path2BrowserBtn_Click(object sender, EventArgs e)
            => this.MovePathLabel2.Text = ActionManager.GetDirectoryPath(this.MovePathLabel2.Text);
    }
}
