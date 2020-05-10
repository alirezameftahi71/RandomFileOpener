using RandomFileOpener.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public class OptionsManager
    {
        public static OptionsManager Instance { get; private set; }
        static OptionsManager()
        {
            OptionsManager.Instance = new OptionsManager();
        }

        public OptionsManager()
        {
            this.SearchSubDir = Properties.Settings.Default.SearchSubDir;
            this.SearchUnique = Properties.Settings.Default.SearchUnique;
            this.InstantOpen = Properties.Settings.Default.InstantOpen;
            this.MainPath = Properties.Settings.Default.MainPath;
            this.MovePath1 = Properties.Settings.Default.MovePath1;
            this.MovePath2 = Properties.Settings.Default.MovePath2;
            this.ValidFileExtentions = Properties.Settings.Default.ValidFileExtentions;
        }

        public BindingList<FileItem> StackItems { get; set; } = new BindingList<FileItem>();
        public bool SearchSubDir { get; set; }
        public bool SearchUnique { get; set; }
        public bool InstantOpen { get; set; }
        public string ValidFileExtentions { get; set; }
        public string MainPath { get; set; }
        public string MovePath1 { get; set; }
        public string MovePath2 { get; set; }

        public static void StoreLatestSettings()
        {
            Properties.Settings.Default.SearchSubDir = OptionsManager.Instance.SearchSubDir;
            Properties.Settings.Default.SearchUnique = OptionsManager.Instance.SearchUnique;
            Properties.Settings.Default.InstantOpen = OptionsManager.Instance.InstantOpen;
            Properties.Settings.Default.MainPath = OptionsManager.Instance.MainPath;
            Properties.Settings.Default.MovePath1 = OptionsManager.Instance.MovePath1;
            Properties.Settings.Default.MovePath2 = OptionsManager.Instance.MovePath2;
            Properties.Settings.Default.ValidFileExtentions = OptionsManager.Instance.ValidFileExtentions;
            Properties.Settings.Default.Save();
        }
    }
}
