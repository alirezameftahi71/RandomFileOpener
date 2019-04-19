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
            this.PathLbl = new System.Windows.Forms.Label();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathLbl
            // 
            this.PathLbl.Location = new System.Drawing.Point(148, 64);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(551, 69);
            this.PathLbl.TabIndex = 1;
            this.PathLbl.Text = "Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app!";
            // 
            // RandomBtn
            // 
            this.RandomBtn.Location = new System.Drawing.Point(12, 137);
            this.RandomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(130, 34);
            this.RandomBtn.TabIndex = 2;
            this.RandomBtn.Text = "Random!";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(180, 9);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(371, 31);
            this.HeaderLbl.TabIndex = 3;
            this.HeaderLbl.Text = "Pick An Address and Hit Run!";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(12, 55);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(130, 34);
            this.BrowseBtn.TabIndex = 4;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.HeaderLbl);
            this.Controls.Add(this.RandomBtn);
            this.Controls.Add(this.PathLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Window";
            this.Text = "Random File Opener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button BrowseBtn;
    }
}

