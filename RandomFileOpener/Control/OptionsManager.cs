using RandomFileOpener.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public static class OptionsManager
    {
        public static BindingList<FileItem> StackItems { get; set; } = new BindingList<FileItem>();
        public static bool SearchSubDir { get; set; }
        public static bool SearchUnique { get; set; }
        public static string ValidFileExtentions { get; set; }
        public static string MainPath { get; set; }
        public static string MovePath1 { get; set; }
        public static string MovePath2 { get; set; }
    }
}
