﻿using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public static class Utility
    {
        public static void ShowErrorMessage(string title, string message) => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
}
