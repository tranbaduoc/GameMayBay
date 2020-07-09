namespace BanMayBay
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGame.ImageKey = "Add.gif";
            this.btnNewGame.ImageList = this.imageListMain;
            this.btnNewGame.Location = new System.Drawing.Point(71, 31);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(123, 32);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "About.gif");
            this.imageListMain.Images.SetKeyName(1, "Add.gif");
            this.imageListMain.Images.SetKeyName(2, "Exit.gif");
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.ImageKey = "About.gif";
            this.btnAbout.ImageList = this.imageListMain;
            this.btnAbout.Location = new System.Drawing.Point(71, 81);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(123, 32);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.ImageKey = "Exit.gif";
            this.btnQuit.ImageList = this.imageListMain;
            this.btnQuit.Location = new System.Drawing.Point(71, 181);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 32);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHigh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHigh.ImageKey = "(none)";
            this.btnHigh.ImageList = this.imageListMain;
            this.btnHigh.Location = new System.Drawing.Point(71, 131);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(123, 32);
            this.btnHigh.TabIndex = 2;
            this.btnHigh.Text = "High score";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanMayBay.Properties.Resources.nenMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 240);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnNewGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bắn máy bay";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHigh;
    }
}

