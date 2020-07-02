namespace BanMayBay
{
    partial class frmGame1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblCoint = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picDanLua = new System.Windows.Forms.PictureBox();
            this.picBum = new System.Windows.Forms.PictureBox();
            this.picufo2 = new System.Windows.Forms.PictureBox();
            this.picufo1 = new System.Windows.Forms.PictureBox();
            this.picTien = new System.Windows.Forms.PictureBox();
            this.picDa1 = new System.Windows.Forms.PictureBox();
            this.picDa2 = new System.Windows.Forms.PictureBox();
            this.picMayBay = new System.Windows.Forms.PictureBox();
            this.Danurf1 = new System.Windows.Forms.PictureBox();
            this.Danurf2 = new System.Windows.Forms.PictureBox();
            this.picTangToc = new System.Windows.Forms.PictureBox();
            this.picTangDan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDanLua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picufo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picufo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Danurf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Danurf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTangToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTangDan)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(101, 320);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(168, 37);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblCoint
            // 
            this.lblCoint.AutoSize = true;
            this.lblCoint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCoint.Location = new System.Drawing.Point(12, 9);
            this.lblCoint.Name = "lblCoint";
            this.lblCoint.Size = new System.Drawing.Size(37, 13);
            this.lblCoint.TabIndex = 6;
            this.lblCoint.Text = "Point: ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pause.png");
            this.imageList1.Images.SetKeyName(1, "Play.png");
            this.imageList1.Images.SetKeyName(2, "Stop.png");
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picDanLua
            // 
            this.picDanLua.BackColor = System.Drawing.Color.Transparent;
            this.picDanLua.Image = global::BanMayBay.Properties.Resources.danlua;
            this.picDanLua.Location = new System.Drawing.Point(270, 546);
            this.picDanLua.Name = "picDanLua";
            this.picDanLua.Size = new System.Drawing.Size(16, 26);
            this.picDanLua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDanLua.TabIndex = 4;
            this.picDanLua.TabStop = false;
            this.picDanLua.Visible = false;
            // 
            // picBum
            // 
            this.picBum.BackColor = System.Drawing.Color.Transparent;
            this.picBum.Image = global::BanMayBay.Properties.Resources.hieuungno;
            this.picBum.Location = new System.Drawing.Point(250, 153);
            this.picBum.Name = "picBum";
            this.picBum.Size = new System.Drawing.Size(88, 63);
            this.picBum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBum.TabIndex = 3;
            this.picBum.TabStop = false;
            this.picBum.Visible = false;
            // 
            // picufo2
            // 
            this.picufo2.BackColor = System.Drawing.Color.Transparent;
            this.picufo2.Image = global::BanMayBay.Properties.Resources.man1_2;
            this.picufo2.Location = new System.Drawing.Point(219, 21);
            this.picufo2.Name = "picufo2";
            this.picufo2.Size = new System.Drawing.Size(88, 63);
            this.picufo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picufo2.TabIndex = 3;
            this.picufo2.TabStop = false;
            // 
            // picufo1
            // 
            this.picufo1.BackColor = System.Drawing.Color.Transparent;
            this.picufo1.Image = global::BanMayBay.Properties.Resources.man1;
            this.picufo1.Location = new System.Drawing.Point(26, 183);
            this.picufo1.Name = "picufo1";
            this.picufo1.Size = new System.Drawing.Size(83, 42);
            this.picufo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picufo1.TabIndex = 3;
            this.picufo1.TabStop = false;
            // 
            // picTien
            // 
            this.picTien.BackColor = System.Drawing.Color.Transparent;
            this.picTien.Image = global::BanMayBay.Properties.Resources.itemTien;
            this.picTien.Location = new System.Drawing.Point(121, 42);
            this.picTien.Name = "picTien";
            this.picTien.Size = new System.Drawing.Size(24, 24);
            this.picTien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTien.TabIndex = 2;
            this.picTien.TabStop = false;
            this.picTien.Visible = false;
            // 
            // picDa1
            // 
            this.picDa1.BackColor = System.Drawing.Color.Transparent;
            this.picDa1.Image = global::BanMayBay.Properties.Resources.da2;
            this.picDa1.Location = new System.Drawing.Point(319, 251);
            this.picDa1.Name = "picDa1";
            this.picDa1.Size = new System.Drawing.Size(49, 35);
            this.picDa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDa1.TabIndex = 1;
            this.picDa1.TabStop = false;
            // 
            // picDa2
            // 
            this.picDa2.BackColor = System.Drawing.Color.Transparent;
            this.picDa2.Image = global::BanMayBay.Properties.Resources.da2;
            this.picDa2.Location = new System.Drawing.Point(108, 1);
            this.picDa2.Name = "picDa2";
            this.picDa2.Size = new System.Drawing.Size(49, 35);
            this.picDa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDa2.TabIndex = 1;
            this.picDa2.TabStop = false;
            // 
            // picMayBay
            // 
            this.picMayBay.BackColor = System.Drawing.Color.Transparent;
            this.picMayBay.Image = global::BanMayBay.Properties.Resources.mb_hong;
            this.picMayBay.Location = new System.Drawing.Point(121, 585);
            this.picMayBay.Name = "picMayBay";
            this.picMayBay.Size = new System.Drawing.Size(87, 60);
            this.picMayBay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMayBay.TabIndex = 0;
            this.picMayBay.TabStop = false;
            // 
            // Danurf1
            // 
            this.Danurf1.BackColor = System.Drawing.Color.Transparent;
            this.Danurf1.Image = global::BanMayBay.Properties.Resources.corox;
            this.Danurf1.Location = new System.Drawing.Point(70, 83);
            this.Danurf1.Name = "Danurf1";
            this.Danurf1.Size = new System.Drawing.Size(15, 19);
            this.Danurf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Danurf1.TabIndex = 8;
            this.Danurf1.TabStop = false;
            this.Danurf1.Visible = false;
            // 
            // Danurf2
            // 
            this.Danurf2.BackColor = System.Drawing.Color.Transparent;
            this.Danurf2.Image = global::BanMayBay.Properties.Resources.corox;
            this.Danurf2.Location = new System.Drawing.Point(108, 83);
            this.Danurf2.Name = "Danurf2";
            this.Danurf2.Size = new System.Drawing.Size(15, 19);
            this.Danurf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Danurf2.TabIndex = 8;
            this.Danurf2.TabStop = false;
            this.Danurf2.Visible = false;
            // 
            // picTangToc
            // 
            this.picTangToc.BackColor = System.Drawing.Color.Transparent;
            this.picTangToc.Image = global::BanMayBay.Properties.Resources.itemS;
            this.picTangToc.Location = new System.Drawing.Point(161, 106);
            this.picTangToc.Name = "picTangToc";
            this.picTangToc.Size = new System.Drawing.Size(24, 24);
            this.picTangToc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTangToc.TabIndex = 9;
            this.picTangToc.TabStop = false;
            this.picTangToc.Visible = false;
            // 
            // picTangDan
            // 
            this.picTangDan.BackColor = System.Drawing.Color.Transparent;
            this.picTangDan.Image = global::BanMayBay.Properties.Resources.itemT;
            this.picTangDan.Location = new System.Drawing.Point(245, 106);
            this.picTangDan.Name = "picTangDan";
            this.picTangDan.Size = new System.Drawing.Size(24, 24);
            this.picTangDan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTangDan.TabIndex = 10;
            this.picTangDan.TabStop = false;
            this.picTangDan.Visible = false;
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanMayBay.Properties.Resources.nen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 677);
            this.Controls.Add(this.picTangDan);
            this.Controls.Add(this.picTangToc);
            this.Controls.Add(this.Danurf2);
            this.Controls.Add(this.Danurf1);
            this.Controls.Add(this.lblCoint);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picDanLua);
            this.Controls.Add(this.picBum);
            this.Controls.Add(this.picufo2);
            this.Controls.Add(this.picufo1);
            this.Controls.Add(this.picTien);
            this.Controls.Add(this.picDa1);
            this.Controls.Add(this.picDa2);
            this.Controls.Add(this.picMayBay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bắn máy bay 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDanLua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picufo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picufo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Danurf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Danurf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTangToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTangDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMayBay;
        private System.Windows.Forms.PictureBox picDa2;
        private System.Windows.Forms.PictureBox picDa1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picTien;
        private System.Windows.Forms.PictureBox picufo1;
        private System.Windows.Forms.PictureBox picufo2;
        private System.Windows.Forms.PictureBox picBum;
        private System.Windows.Forms.PictureBox picDanLua;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblCoint;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Danurf1;
        private System.Windows.Forms.PictureBox Danurf2;
        private System.Windows.Forms.PictureBox picTangToc;
        private System.Windows.Forms.PictureBox picTangDan;
    }
}