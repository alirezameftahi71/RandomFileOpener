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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ListSplitCnt = new System.Windows.Forms.SplitContainer();
            this.FilesListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.ControlTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.ActionTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.FindTargetBtn = new System.Windows.Forms.Button();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.ReOpenBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.FuncBtn = new System.Windows.Forms.Button();
            this.ClearStackBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PathLbl = new System.Windows.Forms.Label();
            this.filterTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.filterFormatTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).BeginInit();
            this.ListSplitCnt.Panel1.SuspendLayout();
            this.ListSplitCnt.Panel2.SuspendLayout();
            this.ListSplitCnt.SuspendLayout();
            this.FilesListGroupBox.SuspendLayout();
            this.ControlTableCnt.SuspendLayout();
            this.ActionTableCnt.SuspendLayout();
            this.filterTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListSplitCnt
            // 
            this.ListSplitCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSplitCnt.Location = new System.Drawing.Point(0, 0);
            this.ListSplitCnt.Name = "ListSplitCnt";
            this.ListSplitCnt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ListSplitCnt.Panel1
            // 
            this.ListSplitCnt.Panel1.Controls.Add(this.FilesListGroupBox);
            // 
            // ListSplitCnt.Panel2
            // 
            this.ListSplitCnt.Panel2.Controls.Add(this.ControlTableCnt);
            this.ListSplitCnt.Size = new System.Drawing.Size(841, 664);
            this.ListSplitCnt.SplitterDistance = 231;
            this.ListSplitCnt.TabIndex = 22;
            // 
            // FilesListGroupBox
            // 
            this.FilesListGroupBox.Controls.Add(this.FilesListBox);
            this.FilesListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilesListGroupBox.Name = "FilesListGroupBox";
            this.FilesListGroupBox.Size = new System.Drawing.Size(841, 231);
            this.FilesListGroupBox.TabIndex = 0;
            this.FilesListGroupBox.TabStop = false;
            this.FilesListGroupBox.Text = "Stack";
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
            this.FilesListBox.Size = new System.Drawing.Size(835, 210);
            this.FilesListBox.TabIndex = 1;
            // 
            // ControlTableCnt
            // 
            this.ControlTableCnt.ColumnCount = 1;
            this.ControlTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableCnt.Controls.Add(this.ActionTableCnt, 0, 3);
            this.ControlTableCnt.Controls.Add(this.BrowseBtn, 0, 2);
            this.ControlTableCnt.Controls.Add(this.PathLbl, 0, 1);
            this.ControlTableCnt.Controls.Add(this.filterTypeGroupBox, 0, 0);
            this.ControlTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTableCnt.Location = new System.Drawing.Point(0, 0);
            this.ControlTableCnt.Name = "ControlTableCnt";
            this.ControlTableCnt.RowCount = 4;
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.ControlTableCnt.Size = new System.Drawing.Size(841, 429);
            this.ControlTableCnt.TabIndex = 20;
            // 
            // ActionTableCnt
            // 
            this.ActionTableCnt.ColumnCount = 4;
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.Controls.Add(this.FindTargetBtn, 0, 1);
            this.ActionTableCnt.Controls.Add(this.RandomBtn, 0, 0);
            this.ActionTableCnt.Controls.Add(this.DeleteItemBtn, 2, 0);
            this.ActionTableCnt.Controls.Add(this.ReOpenBtn, 1, 1);
            this.ActionTableCnt.Controls.Add(this.DeleteBtn, 1, 0);
            this.ActionTableCnt.Controls.Add(this.FuncBtn, 2, 1);
            this.ActionTableCnt.Controls.Add(this.ClearStackBtn, 3, 0);
            this.ActionTableCnt.Controls.Add(this.button2, 3, 1);
            this.ActionTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionTableCnt.Location = new System.Drawing.Point(3, 173);
            this.ActionTableCnt.Name = "ActionTableCnt";
            this.ActionTableCnt.RowCount = 2;
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.Size = new System.Drawing.Size(835, 253);
            this.ActionTableCnt.TabIndex = 21;
            // 
            // FindTargetBtn
            // 
            this.FindTargetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTargetBtn.Location = new System.Drawing.Point(3, 128);
            this.FindTargetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindTargetBtn.Name = "FindTargetBtn";
            this.FindTargetBtn.Size = new System.Drawing.Size(202, 123);
            this.FindTargetBtn.TabIndex = 17;
            this.FindTargetBtn.Text = "Show In Explorer";
            this.FindTargetBtn.UseVisualStyleBackColor = true;
            this.FindTargetBtn.Click += new System.EventHandler(this.FindTargetBtn_Click);
            // 
            // RandomBtn
            // 
            this.RandomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomBtn.Location = new System.Drawing.Point(3, 2);
            this.RandomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(202, 122);
            this.RandomBtn.TabIndex = 12;
            this.RandomBtn.Text = "Random!";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteItemBtn.Location = new System.Drawing.Point(419, 3);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(202, 120);
            this.DeleteItemBtn.TabIndex = 18;
            this.DeleteItemBtn.Text = "Delete From List";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // ReOpenBtn
            // 
            this.ReOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReOpenBtn.Location = new System.Drawing.Point(211, 128);
            this.ReOpenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReOpenBtn.Name = "ReOpenBtn";
            this.ReOpenBtn.Size = new System.Drawing.Size(202, 123);
            this.ReOpenBtn.TabIndex = 15;
            this.ReOpenBtn.Text = "ReOpen";
            this.ReOpenBtn.UseVisualStyleBackColor = true;
            this.ReOpenBtn.Click += new System.EventHandler(this.ReOpenBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(211, 2);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(202, 122);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FuncBtn
            // 
            this.FuncBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncBtn.Enabled = false;
            this.FuncBtn.Location = new System.Drawing.Point(419, 129);
            this.FuncBtn.Name = "FuncBtn";
            this.FuncBtn.Size = new System.Drawing.Size(202, 121);
            this.FuncBtn.TabIndex = 19;
            this.FuncBtn.Text = "button2";
            this.FuncBtn.UseVisualStyleBackColor = true;
            // 
            // ClearStackBtn
            // 
            this.ClearStackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearStackBtn.Location = new System.Drawing.Point(627, 3);
            this.ClearStackBtn.Name = "ClearStackBtn";
            this.ClearStackBtn.Size = new System.Drawing.Size(205, 120);
            this.ClearStackBtn.TabIndex = 20;
            this.ClearStackBtn.Text = "Clear Stack";
            this.ClearStackBtn.UseVisualStyleBackColor = true;
            this.ClearStackBtn.Click += new System.EventHandler(this.ClearStackBtn_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(627, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 121);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Location = new System.Drawing.Point(3, 108);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(835, 60);
            this.BrowseBtn.TabIndex = 14;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PathLbl
            // 
            this.PathLbl.AutoEllipsis = true;
            this.PathLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLbl.Location = new System.Drawing.Point(3, 64);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(835, 42);
            this.PathLbl.TabIndex = 19;
            this.PathLbl.Text = "C:\\";
            // 
            // filterTypeGroupBox
            // 
            this.filterTypeGroupBox.Controls.Add(this.filterFormatTbx);
            this.filterTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTypeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filterTypeGroupBox.Name = "filterTypeGroupBox";
            this.filterTypeGroupBox.Size = new System.Drawing.Size(835, 58);
            this.filterTypeGroupBox.TabIndex = 22;
            this.filterTypeGroupBox.TabStop = false;
            this.filterTypeGroupBox.Text = "Filter File Format";
            // 
            // filterFormatTbx
            // 
            this.filterFormatTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterFormatTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFormatTbx.Location = new System.Drawing.Point(3, 18);
            this.filterFormatTbx.Name = "filterFormatTbx";
            this.filterFormatTbx.Size = new System.Drawing.Size(829, 32);
            this.filterFormatTbx.TabIndex = 22;
            this.filterFormatTbx.Text = "*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 664);
            this.Controls.Add(this.ListSplitCnt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Random File Opener";
            this.ListSplitCnt.Panel1.ResumeLayout(false);
            this.ListSplitCnt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).EndInit();
            this.ListSplitCnt.ResumeLayout(false);
            this.FilesListGroupBox.ResumeLayout(false);
            this.ControlTableCnt.ResumeLayout(false);
            this.ActionTableCnt.ResumeLayout(false);
            this.filterTypeGroupBox.ResumeLayout(false);
            this.filterTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ListSplitCnt;
        private System.Windows.Forms.GroupBox FilesListGroupBox;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.TableLayoutPanel ControlTableCnt;
        private System.Windows.Forms.TableLayoutPanel ActionTableCnt;
        private System.Windows.Forms.Button FindTargetBtn;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button ReOpenBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button FuncBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.GroupBox filterTypeGroupBox;
        private System.Windows.Forms.TextBox filterFormatTbx;
        private System.Windows.Forms.Button ClearStackBtn;
        private System.Windows.Forms.Button button2;
    }
}

