namespace RandomFileOpener.View
{
    partial class OptionsWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParentTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.SearchSubDirGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchSubdirOnRdb = new System.Windows.Forms.RadioButton();
            this.SearchSubdirOffRdb = new System.Windows.Forms.RadioButton();
            this.SearchUniqueGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchUniqueOnRdb = new System.Windows.Forms.RadioButton();
            this.SearchUniqueOffRdb = new System.Windows.Forms.RadioButton();
            this.filterTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.filterFormatTbx = new System.Windows.Forms.TextBox();
            this.exampleFilterExtensionLbl = new System.Windows.Forms.Label();
            this.OptionsFooterPanelCnt = new System.Windows.Forms.Panel();
            this.OptionsOKBtn = new System.Windows.Forms.Button();
            this.MoveGroupBox1 = new System.Windows.Forms.GroupBox();
            this.MovePathTbox1 = new System.Windows.Forms.TextBox();
            this.MovePathLbl1 = new System.Windows.Forms.Label();
            this.MoveGroupBox2 = new System.Windows.Forms.GroupBox();
            this.MovePathTbox2 = new System.Windows.Forms.TextBox();
            this.MovePathLbl2 = new System.Windows.Forms.Label();
            this.ParentTableCnt.SuspendLayout();
            this.SearchSubDirGroupBox.SuspendLayout();
            this.SearchUniqueGroupBox.SuspendLayout();
            this.filterTypeGroupBox.SuspendLayout();
            this.OptionsFooterPanelCnt.SuspendLayout();
            this.MoveGroupBox1.SuspendLayout();
            this.MoveGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentTableCnt
            // 
            this.ParentTableCnt.ColumnCount = 2;
            this.ParentTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParentTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParentTableCnt.Controls.Add(this.SearchSubDirGroupBox, 1, 0);
            this.ParentTableCnt.Controls.Add(this.SearchUniqueGroupBox, 0, 0);
            this.ParentTableCnt.Controls.Add(this.filterTypeGroupBox, 0, 1);
            this.ParentTableCnt.Controls.Add(this.OptionsFooterPanelCnt, 0, 3);
            this.ParentTableCnt.Controls.Add(this.MoveGroupBox1, 0, 2);
            this.ParentTableCnt.Controls.Add(this.MoveGroupBox2, 1, 2);
            this.ParentTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentTableCnt.Location = new System.Drawing.Point(0, 0);
            this.ParentTableCnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParentTableCnt.Name = "ParentTableCnt";
            this.ParentTableCnt.RowCount = 4;
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ParentTableCnt.Size = new System.Drawing.Size(385, 299);
            this.ParentTableCnt.TabIndex = 0;
            // 
            // SearchSubDirGroupBox
            // 
            this.SearchSubDirGroupBox.Controls.Add(this.SearchSubdirOnRdb);
            this.SearchSubDirGroupBox.Controls.Add(this.SearchSubdirOffRdb);
            this.SearchSubDirGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchSubDirGroupBox.Location = new System.Drawing.Point(194, 2);
            this.SearchSubDirGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchSubDirGroupBox.Name = "SearchSubDirGroupBox";
            this.SearchSubDirGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchSubDirGroupBox.Size = new System.Drawing.Size(189, 90);
            this.SearchSubDirGroupBox.TabIndex = 0;
            this.SearchSubDirGroupBox.TabStop = false;
            this.SearchSubDirGroupBox.Text = "Search Subdirectories";
            // 
            // SearchSubdirOnRdb
            // 
            this.SearchSubdirOnRdb.AutoSize = true;
            this.SearchSubdirOnRdb.Location = new System.Drawing.Point(5, 54);
            this.SearchSubdirOnRdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchSubdirOnRdb.Name = "SearchSubdirOnRdb";
            this.SearchSubdirOnRdb.Size = new System.Drawing.Size(39, 17);
            this.SearchSubdirOnRdb.TabIndex = 1;
            this.SearchSubdirOnRdb.Text = "On";
            this.SearchSubdirOnRdb.UseVisualStyleBackColor = true;
            // 
            // SearchSubdirOffRdb
            // 
            this.SearchSubdirOffRdb.AutoSize = true;
            this.SearchSubdirOffRdb.Checked = true;
            this.SearchSubdirOffRdb.Location = new System.Drawing.Point(5, 32);
            this.SearchSubdirOffRdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchSubdirOffRdb.Name = "SearchSubdirOffRdb";
            this.SearchSubdirOffRdb.Size = new System.Drawing.Size(39, 17);
            this.SearchSubdirOffRdb.TabIndex = 0;
            this.SearchSubdirOffRdb.TabStop = true;
            this.SearchSubdirOffRdb.Text = "Off";
            this.SearchSubdirOffRdb.UseVisualStyleBackColor = true;
            // 
            // SearchUniqueGroupBox
            // 
            this.SearchUniqueGroupBox.Controls.Add(this.SearchUniqueOnRdb);
            this.SearchUniqueGroupBox.Controls.Add(this.SearchUniqueOffRdb);
            this.SearchUniqueGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchUniqueGroupBox.Location = new System.Drawing.Point(2, 2);
            this.SearchUniqueGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUniqueGroupBox.Name = "SearchUniqueGroupBox";
            this.SearchUniqueGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUniqueGroupBox.Size = new System.Drawing.Size(188, 90);
            this.SearchUniqueGroupBox.TabIndex = 1;
            this.SearchUniqueGroupBox.TabStop = false;
            this.SearchUniqueGroupBox.Text = "Unique Selection";
            // 
            // SearchUniqueOnRdb
            // 
            this.SearchUniqueOnRdb.AutoSize = true;
            this.SearchUniqueOnRdb.Location = new System.Drawing.Point(7, 54);
            this.SearchUniqueOnRdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUniqueOnRdb.Name = "SearchUniqueOnRdb";
            this.SearchUniqueOnRdb.Size = new System.Drawing.Size(39, 17);
            this.SearchUniqueOnRdb.TabIndex = 1;
            this.SearchUniqueOnRdb.Text = "On";
            this.SearchUniqueOnRdb.UseVisualStyleBackColor = true;
            // 
            // SearchUniqueOffRdb
            // 
            this.SearchUniqueOffRdb.AutoSize = true;
            this.SearchUniqueOffRdb.Checked = true;
            this.SearchUniqueOffRdb.Location = new System.Drawing.Point(7, 32);
            this.SearchUniqueOffRdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUniqueOffRdb.Name = "SearchUniqueOffRdb";
            this.SearchUniqueOffRdb.Size = new System.Drawing.Size(39, 17);
            this.SearchUniqueOffRdb.TabIndex = 0;
            this.SearchUniqueOffRdb.TabStop = true;
            this.SearchUniqueOffRdb.Text = "Off";
            this.SearchUniqueOffRdb.UseVisualStyleBackColor = true;
            // 
            // filterTypeGroupBox
            // 
            this.ParentTableCnt.SetColumnSpan(this.filterTypeGroupBox, 2);
            this.filterTypeGroupBox.Controls.Add(this.filterFormatTbx);
            this.filterTypeGroupBox.Controls.Add(this.exampleFilterExtensionLbl);
            this.filterTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTypeGroupBox.Location = new System.Drawing.Point(2, 96);
            this.filterTypeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTypeGroupBox.Name = "filterTypeGroupBox";
            this.filterTypeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTypeGroupBox.Size = new System.Drawing.Size(381, 66);
            this.filterTypeGroupBox.TabIndex = 23;
            this.filterTypeGroupBox.TabStop = false;
            this.filterTypeGroupBox.Text = "Filter File Format";
            // 
            // filterFormatTbx
            // 
            this.filterFormatTbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterFormatTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFormatTbx.Location = new System.Drawing.Point(2, 29);
            this.filterFormatTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterFormatTbx.Name = "filterFormatTbx";
            this.filterFormatTbx.Size = new System.Drawing.Size(377, 27);
            this.filterFormatTbx.TabIndex = 24;
            // 
            // exampleFilterExtensionLbl
            // 
            this.exampleFilterExtensionLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.exampleFilterExtensionLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exampleFilterExtensionLbl.Location = new System.Drawing.Point(2, 15);
            this.exampleFilterExtensionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exampleFilterExtensionLbl.Name = "exampleFilterExtensionLbl";
            this.exampleFilterExtensionLbl.Size = new System.Drawing.Size(377, 14);
            this.exampleFilterExtensionLbl.TabIndex = 23;
            this.exampleFilterExtensionLbl.Text = "ie: *.mp3,*.jpeg,*.docx";
            // 
            // OptionsFooterPanelCnt
            // 
            this.ParentTableCnt.SetColumnSpan(this.OptionsFooterPanelCnt, 2);
            this.OptionsFooterPanelCnt.Controls.Add(this.OptionsOKBtn);
            this.OptionsFooterPanelCnt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsFooterPanelCnt.Location = new System.Drawing.Point(2, 254);
            this.OptionsFooterPanelCnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsFooterPanelCnt.Name = "OptionsFooterPanelCnt";
            this.OptionsFooterPanelCnt.Size = new System.Drawing.Size(381, 43);
            this.OptionsFooterPanelCnt.TabIndex = 24;
            // 
            // OptionsOKBtn
            // 
            this.OptionsOKBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsOKBtn.Location = new System.Drawing.Point(0, 0);
            this.OptionsOKBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsOKBtn.Name = "OptionsOKBtn";
            this.OptionsOKBtn.Size = new System.Drawing.Size(381, 43);
            this.OptionsOKBtn.TabIndex = 0;
            this.OptionsOKBtn.Text = "OK";
            this.OptionsOKBtn.UseVisualStyleBackColor = true;
            this.OptionsOKBtn.Click += new System.EventHandler(this.OptionsOKBtn_Click);
            // 
            // MoveGroupBox1
            // 
            this.MoveGroupBox1.Controls.Add(this.MovePathTbox1);
            this.MoveGroupBox1.Controls.Add(this.MovePathLbl1);
            this.MoveGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveGroupBox1.Location = new System.Drawing.Point(2, 166);
            this.MoveGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveGroupBox1.Name = "MoveGroupBox1";
            this.MoveGroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveGroupBox1.Size = new System.Drawing.Size(188, 81);
            this.MoveGroupBox1.TabIndex = 25;
            this.MoveGroupBox1.TabStop = false;
            this.MoveGroupBox1.Text = "Move Path #1";
            // 
            // MovePathTbox1
            // 
            this.MovePathTbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePathTbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovePathTbox1.Location = new System.Drawing.Point(2, 29);
            this.MovePathTbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovePathTbox1.Name = "MovePathTbox1";
            this.MovePathTbox1.Size = new System.Drawing.Size(184, 27);
            this.MovePathTbox1.TabIndex = 25;
            // 
            // MovePathLbl1
            // 
            this.MovePathLbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePathLbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MovePathLbl1.Location = new System.Drawing.Point(2, 15);
            this.MovePathLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovePathLbl1.Name = "MovePathLbl1";
            this.MovePathLbl1.Size = new System.Drawing.Size(184, 14);
            this.MovePathLbl1.TabIndex = 24;
            this.MovePathLbl1.Text = "ie: D:\\\\";
            // 
            // MoveGroupBox2
            // 
            this.MoveGroupBox2.Controls.Add(this.MovePathTbox2);
            this.MoveGroupBox2.Controls.Add(this.MovePathLbl2);
            this.MoveGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveGroupBox2.Location = new System.Drawing.Point(194, 166);
            this.MoveGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveGroupBox2.Name = "MoveGroupBox2";
            this.MoveGroupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveGroupBox2.Size = new System.Drawing.Size(189, 81);
            this.MoveGroupBox2.TabIndex = 26;
            this.MoveGroupBox2.TabStop = false;
            this.MoveGroupBox2.Text = "Move Path #2";
            // 
            // MovePathTbox2
            // 
            this.MovePathTbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovePathTbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovePathTbox2.Location = new System.Drawing.Point(2, 29);
            this.MovePathTbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovePathTbox2.Name = "MovePathTbox2";
            this.MovePathTbox2.Size = new System.Drawing.Size(185, 27);
            this.MovePathTbox2.TabIndex = 26;
            // 
            // MovePathLbl2
            // 
            this.MovePathLbl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePathLbl2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MovePathLbl2.Location = new System.Drawing.Point(2, 15);
            this.MovePathLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovePathLbl2.Name = "MovePathLbl2";
            this.MovePathLbl2.Size = new System.Drawing.Size(185, 14);
            this.MovePathLbl2.TabIndex = 25;
            this.MovePathLbl2.Text = "ie: C:\\\\";
            // 
            // OptionsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 299);
            this.Controls.Add(this.ParentTableCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OptionsWindows";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsWindows_Load);
            this.ParentTableCnt.ResumeLayout(false);
            this.SearchSubDirGroupBox.ResumeLayout(false);
            this.SearchSubDirGroupBox.PerformLayout();
            this.SearchUniqueGroupBox.ResumeLayout(false);
            this.SearchUniqueGroupBox.PerformLayout();
            this.filterTypeGroupBox.ResumeLayout(false);
            this.filterTypeGroupBox.PerformLayout();
            this.OptionsFooterPanelCnt.ResumeLayout(false);
            this.MoveGroupBox1.ResumeLayout(false);
            this.MoveGroupBox1.PerformLayout();
            this.MoveGroupBox2.ResumeLayout(false);
            this.MoveGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ParentTableCnt;
        private System.Windows.Forms.GroupBox SearchSubDirGroupBox;
        private System.Windows.Forms.GroupBox SearchUniqueGroupBox;
        private System.Windows.Forms.RadioButton SearchUniqueOnRdb;
        private System.Windows.Forms.RadioButton SearchUniqueOffRdb;
        private System.Windows.Forms.RadioButton SearchSubdirOnRdb;
        private System.Windows.Forms.RadioButton SearchSubdirOffRdb;
        private System.Windows.Forms.GroupBox filterTypeGroupBox;
        private System.Windows.Forms.Panel OptionsFooterPanelCnt;
        private System.Windows.Forms.Button OptionsOKBtn;
        private System.Windows.Forms.TextBox filterFormatTbx;
        private System.Windows.Forms.Label exampleFilterExtensionLbl;
        private System.Windows.Forms.GroupBox MoveGroupBox1;
        private System.Windows.Forms.GroupBox MoveGroupBox2;
        private System.Windows.Forms.TextBox MovePathTbox1;
        private System.Windows.Forms.Label MovePathLbl1;
        private System.Windows.Forms.TextBox MovePathTbox2;
        private System.Windows.Forms.Label MovePathLbl2;
    }
}