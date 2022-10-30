namespace Navigateur
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchbar = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.home = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fav = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbar
            // 
            this.searchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbar.Location = new System.Drawing.Point(137, 44);
            this.searchbar.Name = "searchbar";
            this.searchbar.PlaceholderText = "Entrez votre url ici";
            this.searchbar.Size = new System.Drawing.Size(492, 23);
            this.searchbar.TabIndex = 0;
            this.searchbar.Tag = "";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(635, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Rechercher";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.SearchClick);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(8, 44);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(28, 23);
            this.previous.TabIndex = 1;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.PreviousPageClick);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(101, 44);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(29, 23);
            this.next.TabIndex = 1;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.NextPageClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(716, 44);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(68, 23);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Actualiser";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.RefreshPageClick);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 88);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(788, 498);
            this.webBrowser.TabIndex = 3;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(70, 44);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(28, 23);
            this.home.TabIndex = 1;
            this.home.Text = "⌂";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.ToHome);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiqueToolStripMenuItem,
            this.favorisToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // favorisToolStripMenuItem
            // 
            this.favorisToolStripMenuItem.Name = "favorisToolStripMenuItem";
            this.favorisToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.favorisToolStripMenuItem.Text = "Favoris";
            // 
            // fav
            // 
            this.fav.Location = new System.Drawing.Point(38, 44);
            this.fav.Name = "fav";
            this.fav.Size = new System.Drawing.Size(28, 23);
            this.fav.TabIndex = 5;
            this.fav.Text = "❤";
            this.fav.UseVisualStyleBackColor = true;
            this.fav.Click += new System.EventHandler(this.fav_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(790, 583);
            this.Controls.Add(this.fav);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.next);
            this.Controls.Add(this.home);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchbar;
        private Button search;
        private Button previous;
        private Button next;
        private Button refresh;
        private WebBrowser webBrowser;
        private Button home;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem historiqueToolStripMenuItem;
        private ToolStripMenuItem favorisToolStripMenuItem;
        private Button fav;
    }
}