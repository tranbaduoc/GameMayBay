using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BanMayBay
{
    public partial class frmGhiDanh : Form
    {
        public frmGhiDanh()
        {
            InitializeComponent();
        }
        cointPass player = new cointPass();
        List<string> diemcao = new List<string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //FileStream file = File.OpenWrite(Application.StartupPath + "\\DiemCao.txt");
                StreamReader sr = new StreamReader(Application.StartupPath + "\\DiemCao.txt");
                string lineRead = sr.ReadLine();
                while(lineRead!=null)
                {
                    diemcao.Add(lineRead);
                    lineRead = sr.ReadLine();
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\DiemCao.txt", false, Encoding.UTF8);
                diemcao.Add(txtName.Text + "," + player.ToString());
                foreach(string lineWrite in diemcao)
                {
                    sw.WriteLine(lineWrite);
                }
                sw.Close();
                MessageBox.Show("Đã lưu tên thành công!", "Hệ thống");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGhiDanh_Load(object sender, EventArgs e)
        {
            AmThanh("Victory.wav");
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
