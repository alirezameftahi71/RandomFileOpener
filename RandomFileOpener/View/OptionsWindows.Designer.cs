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
            this.OptionsFooterPanelCnt = new System.Windows.Forms.Panel();
            this.OptionsOKBtn = new System.Windows.Forms.Button();
            this.exampleFilterExtensionLbl = new System.Windows.Forms.Label();
            this.filterFormatTbx = new System.Windows.Forms.TextBox();
            this.ParentTableCnt.SuspendLayout();
            this.SearchSubDirGroupBox.SuspendLayout();
            this.SearchUniqueGroupBox.SuspendLayout();
            this.filterTypeGroupBox.SuspendLayout();
            this.OptionsFooterPanelCnt.SuspendLayout();
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
            this.ParentTableCnt.Controls.Add(this.OptionsFooterPanelCnt, 0, 2);
            this.ParentTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentTableCnt.Location = new System.Drawing.Point(0, 0);
            this.ParentTableCnt.Name = "ParentTableCnt";
            this.ParentTableCnt.RowCount = 3;
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ParentTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ParentTableCnt.Size = new System.Drawing.Size(513, 263);
            this.ParentTableCnt.TabIndex = 0;
            // 
            // SearchSubDirGroupBox
            // 
            this.SearchSubDirGroupBox.Controls.Add(this.SearchSubdirOnRdb);
            this.SearchSubDirGroupBox.Controls.Add(this.SearchSubdirOffRdb);
            this.SearchSubDirGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchSubDirGroupBox.Location = new System.Drawing.Point(259, 3);
            this.SearchSubDirGroupBox.Name = "SearchSubDirGroupBox";
            this.SearchSubDirGroupBox.Size = new System.Drawing.Size(251, 111);
            this.SearchSubDirGroupBox.TabIndex = 0;
            this.SearchSubDirGroupBox.TabStop = false;
            this.SearchSubDirGroupBox.Text = "Search Subdirectories";
            // 
            // SearchSubdirOnRdb
            // 
            this.SearchSubdirOnRdb.AutoSize = true;
            this.SearchSubdirOnRdb.Location = new System.Drawing.Point(7, 67);
            this.SearchSubdirOnRdb.Name = "SearchSubdirOnRdb";
            this.SearchSubdirOnRdb.Size = new System.Drawing.Size(48, 21);
            this.SearchSubdirOnRdb.TabIndex = 1;
            this.SearchSubdirOnRdb.Text = "On";
            this.SearchSubdirOnRdb.UseVisualStyleBackColor = true;
            // 
            // SearchSubdirOffRdb
            // 
            this.SearchSubdirOffRdb.AutoSize = true;
            this.SearchSubdirOffRdb.Checked = true;
            this.SearchSubdirOffRdb.Location = new System.Drawing.Point(7, 39);
            this.SearchSubdirOffRdb.Name = "SearchSubdirOffRdb";
            this.SearchSubdirOffRdb.Size = new System.Drawing.Size(48, 21);
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
            this.SearchUniqueGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SearchUniqueGroupBox.Name = "SearchUniqueGroupBox";
            this.SearchUniqueGroupBox.Size = new System.Drawing.Size(250, 111);
            this.SearchUniqueGroupBox.TabIndex = 1;
            this.SearchUniqueGroupBox.TabStop = false;
            this.SearchUniqueGroupBox.Text = "Unique Selection";
            // 
            // SearchUniqueOnRdb
            // 
            this.SearchUniqueOnRdb.AutoSize = true;
            this.SearchUniqueOnRdb.Location = new System.Drawing.Point(9, 66);
            this.SearchUniqueOnRdb.Name = "SearchUniqueOnRdb";
            this.SearchUniqueOnRdb.Size = new System.Drawing.Size(48, 21);
            this.SearchUniqueOnRdb.TabIndex = 1;
            this.SearchUniqueOnRdb.Text = "On";
            this.SearchUniqueOnRdb.UseVisualStyleBackColor = true;
            // 
            // SearchUniqueOffRdb
            // 
            this.SearchUniqueOffRdb.AutoSize = true;
            this.SearchUniqueOffRdb.Checked = true;
            this.SearchUniqueOffRdb.Location = new System.Drawing.Point(9, 39);
            this.SearchUniqueOffRdb.Name = "SearchUniqueOffRdb";
            this.SearchUniqueOffRdb.Size = new System.Drawing.Size(48, 21);
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
            this.filterTypeGroupBox.Location = new System.Drawing.Point(3, 120);
            this.filterTypeGroupBox.Name = "filterTypeGroupBox";
            this.filterTypeGroupBox.Size = new System.Drawing.Size(507, 81);
            this.filterTypeGroupBox.TabIndex = 23;
            this.filterTypeGroupBox.TabStop = false;
            this.filterTypeGroupBox.Text = "Filter File Format";
            // 
            // OptionsFooterPanelCnt
            // 
            this.ParentTableCnt.SetColumnSpan(this.OptionsFooterPanelCnt, 2);
            this.OptionsFooterPanelCnt.Controls.Add(this.OptionsOKBtn);
            this.OptionsFooterPanelCnt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsFooterPanelCnt.Location = new System.Drawing.Point(3, 207);
            this.OptionsFooterPanelCnt.Name = "OptionsFooterPanelCnt";
            this.OptionsFooterPanelCnt.Size = new System.Drawing.Size(507, 53);
            this.OptionsFooterPanelCnt.TabIndex = 24;
            // 
            // OptionsOKBtn
            // 
            this.OptionsOKBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsOKBtn.Location = new System.Drawing.Point(0, 0);
            this.OptionsOKBtn.Name = "OptionsOKBtn";
            this.OptionsOKBtn.Size = new System.Drawing.Size(507, 53);
            this.OptionsOKBtn.TabIndex = 0;
            this.OptionsOKBtn.Text = "OK";
            this.OptionsOKBtn.UseVisualStyleBackColor = true;
            this.OptionsOKBtn.Click += new System.EventHandler(this.OptionsOKBtn_Click);
            // 
            // exampleFilterExtensionLbl
            // 
            this.exampleFilterExtensionLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.exampleFilterExtensionLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exampleFilterExtensionLbl.Location = new System.Drawing.Point(3, 18);
            this.exampleFilterExtensionLbl.Name = "exampleFilterExtensionLbl";
            this.exampleFilterExtensionLbl.Size = new System.Drawing.Size(501, 17);
            this.exampleFilterExtensionLbl.TabIndex = 23;
            this.exampleFilterExtensionLbl.Text = "ie: *.mp3,*.jpeg,*.docx";
            // 
            // filterFormatTbx
            // 
            this.filterFormatTbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterFormatTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFormatTbx.Location = new System.Drawing.Point(3, 35);
            this.filterFormatTbx.Name = "filterFormatTbx";
            this.filterFormatTbx.Size = new System.Drawing.Size(501, 32);
            this.filterFormatTbx.TabIndex = 24;
            // 
            // OptionsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 263);
            this.Controls.Add(this.ParentTableCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}