using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFileOpener
{
    public partial class Window:Form
    {
        public Window() => this.InitializeComponent();

        private void LinkLabel1_LinkClicked(object sender,LinkLabelLinkClickedEventArgs e) =>
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        private void Button1_Click(object sender,EventArgs e) => MessageBox.Show("Thanks!");

    }
}
