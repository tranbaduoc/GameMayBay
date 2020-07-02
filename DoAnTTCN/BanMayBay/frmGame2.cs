using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMayBay
{
    public partial class frmGame2 : Form
    {
        int healthurf1 = 2, healthurf2 = 2;
        bool checkBanUfo1 = false, checkBanUfo2 = false;
        cointPass TienHa = new cointPass();
        private int vDa = 2;
        private int vItem = 3;
        private static int vUFO = 2;
        private int speed = 8;
        private int vDan = 4;
        private bool checkBan = false;

        bool Danufo1Tontai = false;
        bool Danufo2Tontai = false;
        public frmGame2()
        {
            InitializeComponent();
        }
        Random rdDa = new Random();
        Random rdBoss = new Random();
        private void MoveDa(int vDa)
        {
            if (picDa1.Top > this.Height)
            {
                picDa1.Visible = true;
                picBum.Visible = false;
                int x = rdDa.Next(50, 150);
                picDa1.Location = new Point(x, 0);
            }
            if (picDa2.Top > this.Height)
            {

                picDa2.Visible = true;
                picBum.Visible = false;
                int x = rdDa.Next(220, 350);
                picDa2.Location = new Point(x, 0);
            }

            picDa1.Top += vDa; if (picDa2.Top > this.Height)
            {

                picDa3.Visible = true;
                picBum.Visible = false;
                int x = rdDa.Next(50, 350);
                picDa3.Location = new Point(x, 0);
            }

            picDa1.Top += vDa;
            picDa2.Top += vDa;
            picDa3.Top += vDa;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveItem();
            MoveDa(vDa);
            MoveUFO(vUFO);
            MoveDan(vDan);
            AnTien();
            TangTocDan();
            NoTung();
            HienThiDiem();
            GameOver();
            tuBan();
        }
        private void tuBan()
        {
            checkBan = true;
            if (picDanLua.Visible == false)
                this.picDanLua.Location = new Point(picMayBay.Location.X + picMayBay.Width / 2 - picDanLua.Width / 2, picMayBay.Location.Y - 20);
            picDanLua.Visible = true;
        }
        private void HienThiDiem()
        {
            lblCoint.Text = "Points: " + TienHa.ToString();
        }

        int vufo1 = vUFO - 1;
        int vufo2 = vUFO;
        private void MoveUFO(int vUFO)
        {

            if (picufo1.Right >= this.Width - 20)
            {
                picufo1.Visible = true;
                picBum.Visible = false;
                vufo1 = -vUFO + 1;
            }
            if (picufo1.Left <= this.Width - 400)
            {
                vufo1 = vUFO - 1;
            }
            if (picufo2.Right >= this.Width - 20)
            {
                picufo2.Visible = true;
                picBum.Visible = false;
                vufo2 = -vUFO;
            }
            if (picufo2.Left <= this.Width - 400) vufo2 = vUFO;
            picufo1.Left += vufo1;
            picufo2.Left += vufo2;
        }

        private void frmGame2_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblGameOver.Visible == false)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                    if (0 <= picMayBay.Left - speed)
                    { picMayBay.Left -= speed; }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                    if (this.Width >= picMayBay.Right + speed + 10)
                    { picMayBay.Left += speed; }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                    if (0 <= picMayBay.Top - speed)
                    { picMayBay.Top -= speed; }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                    if (this.Height >= picMayBay.Bottom + picMayBay.Height)
                    { picMayBay.Top += speed; }
                if (e.KeyCode == Keys.P)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
                if (e.KeyCode == Keys.R)
                {
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                }
            }
        }

        private void MoveDan(int vDan)
        {
            //máy bay
            if (checkBan == true)
            {
                picDanLua.Top -= vDan;

            }

            if (picDanLua.Top < this.Height - 720)
            {
                checkBan = false;
                picDanLua.Visible = false;
            }
            if (Danufo1Tontai || Danufo2Tontai)
            {
                //Danufo1
                if (checkBanUfo1 == true)
                {
                    Danurf1.Top += vDan - 3;
                    Danurf1.Visible = true;
                }

                if (Danurf1.Top > this.Height)
                {
                    checkBanUfo1 = false;
                    Danurf1.Visible = false;
                    Danufo1Tontai = false;
                }
                //Danurf2
                if (checkBanUfo2 == true)
                {
                    Danurf2.Top += vDan - 2;
                    Danurf2.Visible = true;
                }

                if (Danurf2.Top > this.Height)
                {
                    checkBanUfo2 = false;
                    Danurf2.Visible = false;
                    Danufo2Tontai = false;
                }
            }
        }
        PictureBox chonSuKien()
        {
            Random rd = new Random();
            int loai = rd.Next(0, 4);
            if (loai == 0)
            {
                picTangToc.Visible = true;
                //moveItem(picTangToc);
                return picTangToc;
            }
            //else if (loai == 1) return picTangDan;
            picTien.Visible = true;
            //moveItem(picTien);
            return picTien;
        }
        private void moveItem()
        {
            if (picTien.Visible == true)
            {
                if (picTien.Top > this.Height)
                {
                    picTien.Visible = false;
                }
                picTien.Top += vItem;
            }
            if (picTangToc.Visible == true)
            {
                if (picTangToc.Top > this.Height)
                {
                    picTangToc.Visible = false;
                }
                picTangToc.Top += vItem;
            }
        }
        private void NoTung()
        {
            if (picDanLua.Bounds.IntersectsWith(picDa1.Bounds) && picDanLua.Visible == true && picDa1.Visible == true)
            {
                this.picBum.Location = new Point(picDa1.Location.X, picDa1.Location.Y);
                picBum.Visible = true;
                picDa1.Visible = false;
                picDanLua.Visible = false;
                picTien.Location= new Point(picDa1.Location.X, picDa1.Location.Y);
            }
            if (picDanLua.Bounds.IntersectsWith(picDa2.Bounds) && picDanLua.Visible == true && picDa2.Visible == true)
            {
                this.picBum.Location = new Point(picDa2.Location.X, picDa2.Location.Y);
                picBum.Visible = true;
                picDa2.Visible = false;
                picDanLua.Visible = false;
            }
            if (picDanLua.Bounds.IntersectsWith(picufo1.Bounds) && picDanLua.Visible == true && picufo1.Visible == true)
            {
                healthurf1++;
                    picDanLua.Visible = false;
                if (healthurf1 % 2 == 0)
                {
                    TienHa.Pass+=2;
                    this.picBum.Location = new Point(picufo1.Location.X, picufo1.Location.Y);
                    picBum.Visible = true;
                    picufo1.Visible = false;
                    chonSuKien().Location = new Point(picufo1.Location.X + picufo1.Width / 2 - chonSuKien().Width / 2, picufo1.Location.Y + chonSuKien().Height);
                }
            }
            if (picDanLua.Bounds.IntersectsWith(picufo2.Bounds) && picDanLua.Visible == true && picufo2.Visible == true)
            {
                healthurf2++;
                    picDanLua.Visible = false;
                if (healthurf2 % 3 == 0)
                {
                    TienHa.Pass+=3;
                    this.picBum.Location = new Point(picufo2.Location.X, picufo2.Location.Y);
                    picBum.Visible = true;
                    picufo2.Visible = false;
                    chonSuKien().Location = new Point(picufo2.Location.X + picufo2.Width / 2 - chonSuKien().Width / 2, picufo2.Location.Y + chonSuKien().Height);
                }
            }


        }
        private void AnTien()
        {
            if (picMayBay.Bounds.IntersectsWith(picTien.Bounds) && picTien.Visible == true)
            {
                picTien.Visible = false;
                TienHa.Coint++;
            }
        }
        int dem5s = 0;
        bool tang = false;
        private void TangTocDan()
        {
            if (picMayBay.Bounds.IntersectsWith(picTangToc.Bounds) && picTangToc.Visible == true)
            {
                vDan = 6;
                picTangToc.Visible = false;
                tang = true;
            }
            if (dem5s < 1000 && tang == true)
            {
                dem5s++;
            }
            else
            {
                dem5s = 0;
                vDan = 4;
                tang = false;
            }
        }
        private void GameOver()
        {
            if ((picMayBay.Bounds.IntersectsWith(picDa1.Bounds) && picDa1.Visible == true) 
                ||(picMayBay.Bounds.IntersectsWith(picDa2.Bounds) && picDa2.Visible == true)
                || (picMayBay.Bounds.IntersectsWith(picDa3.Bounds) && picDa3.Visible == true)
                || (picMayBay.Bounds.IntersectsWith(picufo1.Bounds) && picufo1.Visible == true)
                || (picMayBay.Bounds.IntersectsWith(picufo2.Bounds) && picufo2.Visible == true)
                || (picMayBay.Bounds.IntersectsWith(Danurf1.Bounds) && Danurf1.Visible == true)
                || (picMayBay.Bounds.IntersectsWith(Danurf2.Bounds) && Danurf2.Visible == true))
            {
                this.picBum.Location = new Point(picMayBay.Location.X, picMayBay.Location.Y);
                picBum.Visible = true;
                picMayBay.Visible = false;
                timer1.Stop();
                lblGameOver.Visible = true;
                this.Close();
            }

        }

        int time = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            if (time % 10 == 0 && Danurf1.Visible == false)
            {
                NhaDanURF1();
            }
            if (time % 20 == 0 && Danurf2.Visible == false)
            {
                NhaDanURF2();
                time = 0;
            }
            CheckPass();
        }

        private void NhaDanURF2()
        {
            Danufo2Tontai = true;
            checkBanUfo2 = true;
            Danurf2.Location = new
                Point(picufo2.Location.X + picufo2.Width / 2 - Danurf2.Width / 2, picufo2.Location.Y + picufo2.Height);
            Danurf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Danurf2.Visible = false;
        }


        private void NhaDanURF1()
        {
            Danufo1Tontai = true;
            checkBanUfo1 = true;
            Danurf1.Location = new
                Point(picufo1.Location.X + picufo1.Width / 2 - Danurf1.Width / 2, picufo1.Location.Y + picufo1.Height);
            Danurf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Danurf1.Visible = false;
        }
        private void CheckPass()
        {
            if (TienHa.Coint >= 2 && TienHa.Pass >= 2)
            {
                DialogResult = DialogResult.OK;
                GameOver();
            }
        }
    }
}
