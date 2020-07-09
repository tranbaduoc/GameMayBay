using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMayBay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmGame1 game1 = new frmGame1();
            frmGame2 game2 = new frmGame2();
            frmGame3 game3 = new frmGame3();
            frmGhiDanh diemcao = new frmGhiDanh();
            if (game1.ShowDialog()==DialogResult.OK)
            {
                if(MessageBox.Show("Bạn đã win màn 1. Bạn có muốn chơi tiếp k?","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(game2.ShowDialog()==DialogResult.OK)
                    {
                       if( MessageBox.Show("Bạn đã win màn 2 \n Bạn có muốn tiếp tục không?", "Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            if(game3.ShowDialog()==DialogResult.OK)
                            {
                                MessageBox.Show("Bạn đã lọt top người chơi giỏi","Hệ thống");
                                diemcao.ShowDialog();
                            }
                            else
                            {
                                player.Coint = 0;
                                player.Pass = 0;
                                AmThanh("GameOver.wav");
                                MessageBox.Show("Bạn đã thua.\n Lêu lêu cái đồ chơi dốt.\n Có cái kỷ lục cũng không phá được.");
                            }
                        }
                    }
                    else
                    {
                        player.Coint = 0;
                        player.Pass = 0;
                        AmThanh("GameOver.wav");
                        MessageBox.Show("Bạn đã thua", "Hệ thống");
                    }
                }
            }
            else
            {
                player.Coint = 0;
                player.Pass = 0;
                AmThanh("GameOver.wav");
                MessageBox.Show("Bạn đã thua", "Hệ thống");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:\t PHẠM VIỆT HOÀNG \r\nCách chơi:\r\n\t Bạn điều hướng bằng các phím điều hướng hoặc A,D,W,S \r\n \tNhấn phím space để bắn và phải tránh đạn cùng với đá rơi \r\n\ttích lũy điểu và nhặt skin để thay đổi đạn", "Information");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                Application.Exit();
        }
        cointPass player = new cointPass();
        List<string> diemcao = new List<string>();
        private void btnHigh_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\DiemCao.txt");
            string lineRead = sr.ReadLine();
            while (lineRead != null)
            {
                diemcao.Add(lineRead);
                lineRead = sr.ReadLine();
            }
            sr.Close();
            Dictionary<string, int> playerPro = new Dictionary<string, int>();
            foreach (string line in diemcao)
            {
                try
                {
                    string name = line.Split(',')[0];
                    int score = int.Parse(line.Split(',')[1]);
                    playerPro.Add(name, score);
                }
                catch { }
                
            }

            //sx người chơi theo thứ tự tăng dần.
            var items = from pair in playerPro
                        orderby pair.Value ascending
                        select pair;
            //sx người chơi theo thứ tự giảm dần.
            items = from pair in playerPro
                    orderby pair.Value descending
                    select pair;
            foreach (KeyValuePair<string, int> pair in items)
            {
                MessageBox.Show("Người chơi có số điểm cao nhất là: "+pair.Key + ".\nVới số điểm là: " + pair.Value,"Hệ thống! ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AmThanh("nen.wav");
        }

        private void AmThanh(string name)
        {
            Thread th1 = new Thread(new ThreadStart(() =>
            {
                try
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(name);
                    player.Play();
                }
                catch { }
            }));
            th1.Start();
            th1.IsBackground = true;
        }
    }
}
