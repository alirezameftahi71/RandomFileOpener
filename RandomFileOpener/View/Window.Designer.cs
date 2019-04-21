namespace RandomFileOpener
{
    partial class MainWindow
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
            if(disposing&&(components!=null))
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
            this.LogSplitCnt = new System.Windows.Forms.SplitContainer();
            this.ListSplitCnt = new System.Windows.Forms.SplitContainer();
            this.FilesListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.BrowseTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.PathLbl = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.ActionTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ReOpenBtn = new System.Windows.Forms.Button();
            this.FindTargetBtn = new System.Windows.Forms.Button();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.LogLbl = new System.Windows.Forms.Label();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.FuncBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogSplitCnt)).BeginInit();
            this.LogSplitCnt.Panel1.SuspendLayout();
            this.LogSplitCnt.Panel2.SuspendLayout();
            this.LogSplitCnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).BeginInit();
            this.ListSplitCnt.Panel1.SuspendLayout();
            this.ListSplitCnt.Panel2.SuspendLayout();
            this.ListSplitCnt.SuspendLayout();
            this.FilesListGroupBox.SuspendLayout();
            this.BrowseTableCnt.SuspendLayout();
            this.ActionTableCnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogSplitCnt
            // 
            this.LogSplitCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogSplitCnt.Location = new System.Drawing.Point(0, 0);
            this.LogSplitCnt.Name = "LogSplitCnt";
            // 
            // LogSplitCnt.Panel1
            // 
            this.LogSplitCnt.Panel1.Controls.Add(this.ListSplitCnt);
            this.LogSplitCnt.Panel1.Controls.Add(this.ActionTableCnt);
            this.LogSplitCnt.Panel1.Controls.Add(this.HeaderLbl);
            // 
            // LogSplitCnt.Panel2
            // 
            this.LogSplitCnt.Panel2.Controls.Add(this.LogLbl);
            this.LogSplitCnt.Size = new System.Drawing.Size(1016, 619);
            this.LogSplitCnt.SplitterDistance = 558;
            this.LogSplitCnt.TabIndex = 0;
            // 
            // ListSplitCnt
            // 
            this.ListSplitCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSplitCnt.Location = new System.Drawing.Point(0, 52);
            this.ListSplitCnt.Name = "ListSplitCnt";
            this.ListSplitCnt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ListSplitCnt.Panel1
            // 
            this.ListSplitCnt.Panel1.Controls.Add(this.FilesListGroupBox);
            // 
            // ListSplitCnt.Panel2
            // 
            this.ListSplitCnt.Panel2.Controls.Add(this.BrowseTableCnt);
            this.ListSplitCnt.Size = new System.Drawing.Size(558, 362);
            this.ListSplitCnt.SplitterDistance = 235;
            this.ListSplitCnt.TabIndex = 21;
            // 
            // FilesListGroupBox
            // 
            this.FilesListGroupBox.Controls.Add(this.FilesListBox);
            this.FilesListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilesListGroupBox.Name = "FilesListGroupBox";
            this.FilesListGroupBox.Size = new System.Drawing.Size(558, 235);
            this.FilesListGroupBox.TabIndex = 0;
            this.FilesListGroupBox.TabStop = false;
            this.FilesListGroupBox.Text = "Items Stack";
            // 
            // FilesListBox
            // 
            this.FilesListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(3, 18);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(552, 214);
            this.FilesListBox.TabIndex = 1;
            // 
            // BrowseTableCnt
            // 
            this.BrowseTableCnt.ColumnCount = 1;
            this.BrowseTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.Controls.Add(this.PathLbl, 0, 0);
            this.BrowseTableCnt.Controls.Add(this.BrowseBtn, 0, 1);
            this.BrowseTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseTableCnt.Location = new System.Drawing.Point(0, 0);
            this.BrowseTableCnt.Name = "BrowseTableCnt";
            this.BrowseTableCnt.RowCount = 2;
            this.BrowseTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.Size = new System.Drawing.Size(558, 123);
            this.BrowseTableCnt.TabIndex = 20;
            // 
            // PathLbl
            // 
            this.PathLbl.AutoEllipsis = true;
            this.PathLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLbl.Location = new System.Drawing.Point(3, 0);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(552, 61);
            this.PathLbl.TabIndex = 19;
            this.PathLbl.Text = "C:\\";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Location = new System.Drawing.Point(3, 63);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(552, 58);
            this.BrowseBtn.TabIndex = 14;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ActionTableCnt
            // 
            this.ActionTableCnt.ColumnCount = 3;
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ActionTableCnt.Controls.Add(this.RandomBtn, 0, 0);
            this.ActionTableCnt.Controls.Add(this.DeleteBtn, 1, 0);
            this.ActionTableCnt.Controls.Add(this.ReOpenBtn, 1, 1);
            this.ActionTableCnt.Controls.Add(this.FindTargetBtn, 0, 1);
            this.ActionTableCnt.Controls.Add(this.DeleteItemBtn, 2, 0);
            this.ActionTableCnt.Controls.Add(this.FuncBtn, 2, 1);
            this.ActionTableCnt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionTableCnt.Location = new System.Drawing.Point(0, 414);
            this.ActionTableCnt.Name = "ActionTableCnt";
            this.ActionTableCnt.RowCount = 2;
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.Size = new System.Drawing.Size(558, 205);
            this.ActionTableCnt.TabIndex = 19;
            // 
            // RandomBtn
            // 
            this.RandomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomBtn.Location = new System.Drawing.Point(3, 2);
            this.RandomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(179, 98);
            this.RandomBtn.TabIndex = 12;
            this.RandomBtn.Text = "Random!";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(188, 2);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(179, 98);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ReOpenBtn
            // 
            this.ReOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReOpenBtn.Location = new System.Drawing.Point(188, 104);
            this.ReOpenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReOpenBtn.Name = "ReOpenBtn";
            this.ReOpenBtn.Size = new System.Drawing.Size(179, 99);
            this.ReOpenBtn.TabIndex = 15;
            this.ReOpenBtn.Text = "ReOpen";
            this.ReOpenBtn.UseVisualStyleBackColor = true;
            this.ReOpenBtn.Click += new System.EventHandler(this.ReOpenBtn_Click);
            // 
            // FindTargetBtn
            // 
            this.FindTargetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTargetBtn.Location = new System.Drawing.Point(3, 104);
            this.FindTargetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindTargetBtn.Name = "FindTargetBtn";
            this.FindTargetBtn.Size = new System.Drawing.Size(179, 99);
            this.FindTargetBtn.TabIndex = 17;
            this.FindTargetBtn.Text = "Show In Explorer";
            this.FindTargetBtn.UseVisualStyleBackColor = true;
            this.FindTargetBtn.Click += new System.EventHandler(this.FindTargetBtn_Click);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(0, 0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(558, 52);
            this.HeaderLbl.TabIndex = 13;
            this.HeaderLbl.Text = "Random File Opener";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogLbl
            // 
            this.LogLbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.LogLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogLbl.Location = new System.Drawing.Point(0, 0);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(454, 619);
            this.LogLbl.TabIndex = 19;
            this.LogLbl.Text = "Log...";
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteItemBtn.Location = new System.Drawing.Point(373, 3);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(182, 96);
            this.DeleteItemBtn.TabIndex = 18;
            this.DeleteItemBtn.Text = "Delete From List";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // FuncBtn
            // 
            this.FuncBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncBtn.Enabled = false;
            this.FuncBtn.Location = new System.Drawing.Point(373, 105);
            this.FuncBtn.Name = "FuncBtn";
            this.FuncBtn.Size = new System.Drawing.Size(182, 97);
            this.FuncBtn.TabIndex = 19;
            this.FuncBtn.Text = "button2";
            this.FuncBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 619);
            this.Controls.Add(this.LogSplitCnt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Random File Opener";
            this.LogSplitCnt.Panel1.ResumeLayout(false);
            this.LogSplitCnt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogSplitCnt)).EndInit();
            this.LogSplitCnt.ResumeLayout(false);
            this.ListSplitCnt.Panel1.ResumeLayout(false);
            this.ListSplitCnt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).EndInit();
            this.ListSplitCnt.ResumeLayout(false);
            this.FilesListGroupBox.ResumeLayout(false);
            this.BrowseTableCnt.ResumeLayout(false);
            this.ActionTableCnt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer LogSplitCnt;
        private System.Windows.Forms.Button FindTargetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ReOpenBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Label LogLbl;
        private System.Windows.Forms.TableLayoutPanel ActionTableCnt;
        private System.Windows.Forms.TableLayoutPanel BrowseTableCnt;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.SplitContainer ListSplitCnt;
        private System.Windows.Forms.GroupBox FilesListGroupBox;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button FuncBtn;
    }
}

