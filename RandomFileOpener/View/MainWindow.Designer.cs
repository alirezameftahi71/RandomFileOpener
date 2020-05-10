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
            this.MovePathBtn2 = new System.Windows.Forms.Button();
            this.FindTargetBtn = new System.Windows.Forms.Button();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.ReOpenBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearStackBtn = new System.Windows.Forms.Button();
            this.MovePathBtn1 = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PathLbl = new System.Windows.Forms.Label();
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.ToolsMenuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuMemberOption = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).BeginInit();
            this.ListSplitCnt.Panel1.SuspendLayout();
            this.ListSplitCnt.Panel2.SuspendLayout();
            this.ListSplitCnt.SuspendLayout();
            this.FilesListGroupBox.SuspendLayout();
            this.ControlTableCnt.SuspendLayout();
            this.ActionTableCnt.SuspendLayout();
            this.FileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListSplitCnt
            // 
            this.ListSplitCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSplitCnt.Location = new System.Drawing.Point(0, 24);
            this.ListSplitCnt.Margin = new System.Windows.Forms.Padding(2);
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
            this.ListSplitCnt.Size = new System.Drawing.Size(631, 516);
            this.ListSplitCnt.SplitterDistance = 215;
            this.ListSplitCnt.SplitterWidth = 3;
            this.ListSplitCnt.TabIndex = 22;
            // 
            // FilesListGroupBox
            // 
            this.FilesListGroupBox.Controls.Add(this.FilesListBox);
            this.FilesListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilesListGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilesListGroupBox.Name = "FilesListGroupBox";
            this.FilesListGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.FilesListGroupBox.Size = new System.Drawing.Size(631, 215);
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
            this.FilesListBox.Location = new System.Drawing.Point(2, 15);
            this.FilesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(627, 198);
            this.FilesListBox.TabIndex = 1;
            this.FilesListBox.DoubleClick += new System.EventHandler(this.FilesListBox_DoubleClick);
            // 
            // ControlTableCnt
            // 
            this.ControlTableCnt.ColumnCount = 1;
            this.ControlTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableCnt.Controls.Add(this.ActionTableCnt, 0, 3);
            this.ControlTableCnt.Controls.Add(this.BrowseBtn, 0, 2);
            this.ControlTableCnt.Controls.Add(this.PathLbl, 0, 1);
            this.ControlTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTableCnt.Location = new System.Drawing.Point(0, 0);
            this.ControlTableCnt.Margin = new System.Windows.Forms.Padding(2);
            this.ControlTableCnt.Name = "ControlTableCnt";
            this.ControlTableCnt.RowCount = 4;
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.ControlTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.ControlTableCnt.Size = new System.Drawing.Size(631, 298);
            this.ControlTableCnt.TabIndex = 20;
            // 
            // ActionTableCnt
            // 
            this.ActionTableCnt.ColumnCount = 4;
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ActionTableCnt.Controls.Add(this.MovePathBtn2, 3, 1);
            this.ActionTableCnt.Controls.Add(this.FindTargetBtn, 0, 1);
            this.ActionTableCnt.Controls.Add(this.RandomBtn, 0, 0);
            this.ActionTableCnt.Controls.Add(this.DeleteItemBtn, 2, 0);
            this.ActionTableCnt.Controls.Add(this.ReOpenBtn, 1, 1);
            this.ActionTableCnt.Controls.Add(this.DeleteBtn, 1, 0);
            this.ActionTableCnt.Controls.Add(this.ClearStackBtn, 3, 0);
            this.ActionTableCnt.Controls.Add(this.MovePathBtn1, 2, 1);
            this.ActionTableCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionTableCnt.Location = new System.Drawing.Point(2, 89);
            this.ActionTableCnt.Margin = new System.Windows.Forms.Padding(2);
            this.ActionTableCnt.Name = "ActionTableCnt";
            this.ActionTableCnt.RowCount = 2;
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.Size = new System.Drawing.Size(627, 207);
            this.ActionTableCnt.TabIndex = 21;
            // 
            // MovePathBtn2
            // 
            this.MovePathBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovePathBtn2.Location = new System.Drawing.Point(470, 105);
            this.MovePathBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.MovePathBtn2.Name = "MovePathBtn2";
            this.MovePathBtn2.Size = new System.Drawing.Size(155, 100);
            this.MovePathBtn2.TabIndex = 22;
            this.MovePathBtn2.Text = "Move To Path #2";
            this.MovePathBtn2.UseVisualStyleBackColor = true;
            this.MovePathBtn2.Click += new System.EventHandler(this.MovePathBtn2_Click);
            // 
            // FindTargetBtn
            // 
            this.FindTargetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTargetBtn.Location = new System.Drawing.Point(2, 105);
            this.FindTargetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FindTargetBtn.Name = "FindTargetBtn";
            this.FindTargetBtn.Size = new System.Drawing.Size(152, 100);
            this.FindTargetBtn.TabIndex = 17;
            this.FindTargetBtn.Text = "Show In Explorer";
            this.FindTargetBtn.UseVisualStyleBackColor = true;
            this.FindTargetBtn.Click += new System.EventHandler(this.FindTargetBtn_Click);
            // 
            // RandomBtn
            // 
            this.RandomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomBtn.Location = new System.Drawing.Point(2, 2);
            this.RandomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(152, 99);
            this.RandomBtn.TabIndex = 12;
            this.RandomBtn.Text = "Random!";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteItemBtn.Location = new System.Drawing.Point(314, 2);
            this.DeleteItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(152, 99);
            this.DeleteItemBtn.TabIndex = 18;
            this.DeleteItemBtn.Text = "Delete From Stack";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // ReOpenBtn
            // 
            this.ReOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReOpenBtn.Location = new System.Drawing.Point(158, 105);
            this.ReOpenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReOpenBtn.Name = "ReOpenBtn";
            this.ReOpenBtn.Size = new System.Drawing.Size(152, 100);
            this.ReOpenBtn.TabIndex = 15;
            this.ReOpenBtn.Text = "ReOpen";
            this.ReOpenBtn.UseVisualStyleBackColor = true;
            this.ReOpenBtn.Click += new System.EventHandler(this.ReOpenBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(158, 2);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(152, 99);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearStackBtn
            // 
            this.ClearStackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearStackBtn.Location = new System.Drawing.Point(470, 2);
            this.ClearStackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearStackBtn.Name = "ClearStackBtn";
            this.ClearStackBtn.Size = new System.Drawing.Size(155, 99);
            this.ClearStackBtn.TabIndex = 20;
            this.ClearStackBtn.Text = "Clear Stack";
            this.ClearStackBtn.UseVisualStyleBackColor = true;
            this.ClearStackBtn.Click += new System.EventHandler(this.ClearStackBtn_Click);
            // 
            // MovePathBtn1
            // 
            this.MovePathBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovePathBtn1.Location = new System.Drawing.Point(314, 105);
            this.MovePathBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.MovePathBtn1.Name = "MovePathBtn1";
            this.MovePathBtn1.Size = new System.Drawing.Size(152, 100);
            this.MovePathBtn1.TabIndex = 21;
            this.MovePathBtn1.Tag = "";
            this.MovePathBtn1.Text = "Move To Path #1";
            this.MovePathBtn1.UseVisualStyleBackColor = true;
            this.MovePathBtn1.Click += new System.EventHandler(this.MovePathBtn1_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Location = new System.Drawing.Point(2, 37);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(627, 48);
            this.BrowseBtn.TabIndex = 14;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PathLbl
            // 
            this.PathLbl.AutoEllipsis = true;
            this.PathLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathLbl.Location = new System.Drawing.Point(2, 0);
            this.PathLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(627, 35);
            this.PathLbl.TabIndex = 19;
            this.PathLbl.Text = "C:\\";
            // 
            // FileMenu
            // 
            this.FileMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsMenuMember});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.FileMenu.Size = new System.Drawing.Size(631, 24);
            this.FileMenu.TabIndex = 23;
            this.FileMenu.Text = "menuStrip1";
            // 
            // ToolsMenuMember
            // 
            this.ToolsMenuMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenuMemberOption});
            this.ToolsMenuMember.Name = "ToolsMenuMember";
            this.ToolsMenuMember.Size = new System.Drawing.Size(48, 20);
            this.ToolsMenuMember.Text = "&Tools";
            // 
            // OptionsMenuMemberOption
            // 
            this.OptionsMenuMemberOption.Name = "OptionsMenuMemberOption";
            this.OptionsMenuMemberOption.Size = new System.Drawing.Size(116, 22);
            this.OptionsMenuMemberOption.Text = "&Options";
            this.OptionsMenuMemberOption.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 540);
            this.Controls.Add(this.ListSplitCnt);
            this.Controls.Add(this.FileMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FileMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Random File Opener";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ListSplitCnt.Panel1.ResumeLayout(false);
            this.ListSplitCnt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitCnt)).EndInit();
            this.ListSplitCnt.ResumeLayout(false);
            this.FilesListGroupBox.ResumeLayout(false);
            this.ControlTableCnt.ResumeLayout(false);
            this.ActionTableCnt.ResumeLayout(false);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.Button ClearStackBtn;
        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuMember;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuMemberOption;
        private System.Windows.Forms.Button MovePathBtn2;
        private System.Windows.Forms.Button MovePathBtn1;
    }
}

