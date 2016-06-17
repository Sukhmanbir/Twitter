namespace Twitter
{
    partial class twitter
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.numberOfTweetsLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTweetsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByUserButton = new System.Windows.Forms.Button();
            this.searchByHashtagButton = new System.Windows.Forms.Button();
            this.tweetsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(28, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Twitter Handle or HashTag";
            // 
            // numberOfTweetsLabel
            // 
            this.numberOfTweetsLabel.AutoSize = true;
            this.numberOfTweetsLabel.Location = new System.Drawing.Point(225, 50);
            this.numberOfTweetsLabel.Name = "numberOfTweetsLabel";
            this.numberOfTweetsLabel.Size = new System.Drawing.Size(52, 13);
            this.numberOfTweetsLabel.TabIndex = 1;
            this.numberOfTweetsLabel.Text = "# Tweets";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(31, 84);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // numberOfTweetsTextBox
            // 
            this.numberOfTweetsTextBox.Location = new System.Drawing.Point(228, 84);
            this.numberOfTweetsTextBox.Name = "numberOfTweetsTextBox";
            this.numberOfTweetsTextBox.Size = new System.Drawing.Size(61, 20);
            this.numberOfTweetsTextBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // searchByUserButton
            // 
            this.searchByUserButton.Location = new System.Drawing.Point(391, 50);
            this.searchByUserButton.Name = "searchByUserButton";
            this.searchByUserButton.Size = new System.Drawing.Size(133, 23);
            this.searchByUserButton.TabIndex = 2;
            this.searchByUserButton.Text = "Search By &User ";
            this.searchByUserButton.UseVisualStyleBackColor = true;
            this.searchByUserButton.Click += new System.EventHandler(this.searchByUserButton_Click);
            // 
            // searchByHashtagButton
            // 
            this.searchByHashtagButton.Location = new System.Drawing.Point(391, 84);
            this.searchByHashtagButton.Name = "searchByHashtagButton";
            this.searchByHashtagButton.Size = new System.Drawing.Size(133, 23);
            this.searchByHashtagButton.TabIndex = 3;
            this.searchByHashtagButton.Text = "Search By &HashTag";
            this.searchByHashtagButton.UseVisualStyleBackColor = true;
            this.searchByHashtagButton.Click += new System.EventHandler(this.searchByHashtagButton_Click);
            // 
            // tweetsRichTextBox
            // 
            this.tweetsRichTextBox.Location = new System.Drawing.Point(31, 134);
            this.tweetsRichTextBox.Name = "tweetsRichTextBox";
            this.tweetsRichTextBox.ReadOnly = true;
            this.tweetsRichTextBox.Size = new System.Drawing.Size(493, 245);
            this.tweetsRichTextBox.TabIndex = 7;
            this.tweetsRichTextBox.TabStop = false;
            this.tweetsRichTextBox.Text = "";
            // 
            // twitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.tweetsRichTextBox);
            this.Controls.Add(this.searchByHashtagButton);
            this.Controls.Add(this.searchByUserButton);
            this.Controls.Add(this.numberOfTweetsTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.numberOfTweetsLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "twitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tweeder";
            this.Load += new System.EventHandler(this.twitter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label numberOfTweetsLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox numberOfTweetsTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button searchByUserButton;
        private System.Windows.Forms.Button searchByHashtagButton;
        private System.Windows.Forms.RichTextBox tweetsRichTextBox;
    }
}

