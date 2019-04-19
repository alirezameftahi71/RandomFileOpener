namespace RandomFileOpener
{
    partial class Window
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
            this.ParentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FindTargetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ReOpenBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.LogLbl = new System.Windows.Forms.Label();
            this.ActionTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.BrowseTableCnt = new System.Windows.Forms.TableLayoutPanel();
            this.PathLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParentSplitContainer)).BeginInit();
            this.ParentSplitContainer.Panel1.SuspendLayout();
            this.ParentSplitContainer.Panel2.SuspendLayout();
            this.ParentSplitContainer.SuspendLayout();
            this.ActionTableCnt.SuspendLayout();
            this.BrowseTableCnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentSplitContainer
            // 
            this.ParentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ParentSplitContainer.Name = "ParentSplitContainer";
            // 
            // ParentSplitContainer.Panel1
            // 
            this.ParentSplitContainer.Panel1.Controls.Add(this.BrowseTableCnt);
            this.ParentSplitContainer.Panel1.Controls.Add(this.ActionTableCnt);
            this.ParentSplitContainer.Panel1.Controls.Add(this.HeaderLbl);
            // 
            // ParentSplitContainer.Panel2
            // 
            this.ParentSplitContainer.Panel2.Controls.Add(this.LogLbl);
            this.ParentSplitContainer.Size = new System.Drawing.Size(1016, 487);
            this.ParentSplitContainer.SplitterDistance = 558;
            this.ParentSplitContainer.TabIndex = 0;
            // 
            // FindTargetBtn
            // 
            this.FindTargetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindTargetBtn.Location = new System.Drawing.Point(3, 104);
            this.FindTargetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindTargetBtn.Name = "FindTargetBtn";
            this.FindTargetBtn.Size = new System.Drawing.Size(273, 99);
            this.FindTargetBtn.TabIndex = 17;
            this.FindTargetBtn.Text = "Show In Explorer";
            this.FindTargetBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(282, 2);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(273, 98);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ReOpenBtn
            // 
            this.ReOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReOpenBtn.Location = new System.Drawing.Point(282, 104);
            this.ReOpenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReOpenBtn.Name = "ReOpenBtn";
            this.ReOpenBtn.Size = new System.Drawing.Size(273, 99);
            this.ReOpenBtn.TabIndex = 15;
            this.ReOpenBtn.Text = "ReOpen";
            this.ReOpenBtn.UseVisualStyleBackColor = true;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Location = new System.Drawing.Point(3, 75);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(552, 70);
            this.BrowseBtn.TabIndex = 14;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
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
            // RandomBtn
            // 
            this.RandomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomBtn.Location = new System.Drawing.Point(3, 2);
            this.RandomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(273, 98);
            this.RandomBtn.TabIndex = 12;
            this.RandomBtn.Text = "Random!";
            this.RandomBtn.UseVisualStyleBackColor = true;
            // 
            // LogLbl
            // 
            this.LogLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogLbl.Location = new System.Drawing.Point(0, 0);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(454, 487);
            this.LogLbl.TabIndex = 19;
            this.LogLbl.Text = "Log...";
            // 
            // ActionTableCnt
            // 
            this.ActionTableCnt.ColumnCount = 2;
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.Controls.Add(this.RandomBtn, 0, 0);
            this.ActionTableCnt.Controls.Add(this.DeleteBtn, 1, 0);
            this.ActionTableCnt.Controls.Add(this.ReOpenBtn, 1, 1);
            this.ActionTableCnt.Controls.Add(this.FindTargetBtn, 0, 1);
            this.ActionTableCnt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionTableCnt.Location = new System.Drawing.Point(0, 282);
            this.ActionTableCnt.Name = "ActionTableCnt";
            this.ActionTableCnt.RowCount = 2;
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionTableCnt.Size = new System.Drawing.Size(558, 205);
            this.ActionTableCnt.TabIndex = 19;
            // 
            // BrowseTableCnt
            // 
            this.BrowseTableCnt.ColumnCount = 1;
            this.BrowseTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.Controls.Add(this.PathLbl, 0, 0);
            this.BrowseTableCnt.Controls.Add(this.BrowseBtn, 0, 1);
            this.BrowseTableCnt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrowseTableCnt.Location = new System.Drawing.Point(0, 135);
            this.BrowseTableCnt.Name = "BrowseTableCnt";
            this.BrowseTableCnt.RowCount = 2;
            this.BrowseTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowseTableCnt.Size = new System.Drawing.Size(558, 147);
            this.BrowseTableCnt.TabIndex = 20;
            // 
            // PathLbl
            // 
            this.PathLbl.AutoEllipsis = true;
            this.PathLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLbl.Location = new System.Drawing.Point(3, 0);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(552, 73);
            this.PathLbl.TabIndex = 19;
            this.PathLbl.Text = "C:/Example";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 487);
            this.Controls.Add(this.ParentSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Window";
            this.Text = "Random File Opener";
            this.ParentSplitContainer.Panel1.ResumeLayout(false);
            this.ParentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParentSplitContainer)).EndInit();
            this.ParentSplitContainer.ResumeLayout(false);
            this.ActionTableCnt.ResumeLayout(false);
            this.BrowseTableCnt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ParentSplitContainer;
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
    }
}

