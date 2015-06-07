using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //frmdangnhap f1 = new frmdangnhap();
            //f1.MdiParent = this;
            //f1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmdangnhap f1 = new frmdangnhap();
            //f1.ShowDialog();
            //this.Close();  
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdangki d = new frmdangki();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmcoban f2 = new frmcoban();
            f2.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmthongtincanhan f3 = new frmthongtincanhan();
            f3.ShowDialog();
        }
        
        public int k = 1;
        public void truyen()
        {
            
            if (k == 4)
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                toolStrip1.Enabled = true;
                toolStrip2.Enabled = false;
           
                //groupBox1.Enabled = true;
                //groupBox5.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string ngaythangnam = "";
            string gio = "";
            string tgday = "";
            Hienngay(ref ngaythangnam, ref gio, ref tgday);
            toolStripStatusLabel1.Text += ngaythangnam;
          
            //axWindowsMediaPlayer1.Visible = false;
            //axWindowsMediaPlayer1.URL = "nhac nen.mp3";
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmdangki dk = new frmdangki();
            dk.ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmcoban fc = new frmcoban();
            fc.ShowDialog();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();
            ft.ShowDialog();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            fdm.ShowDialog();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frmchedo fcc = new frmchedo();
            fcc.ShowDialog();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            frmluong rfl = new frmluong();
            rfl.ShowDialog();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmhosothuviec fhtv = new frmhosothuviec();
            fhtv.ShowDialog();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            fpb.ShowDialog();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            frb.ShowDialog();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmbangcong fbc = new frmbangcong();
            fbc.ShowDialog();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frmcoban fcb = new frmcoban();
            fcb.ShowDialog();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ftcn = new frmthongtincanhan();
            ftcn.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            ftk.ShowDialog();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            ftk.ShowDialog();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmchedo fcd = new frmchedo();
            fcd.ShowDialog();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmluong fl = new frmluong();
            fl.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtrogiup ftg = new frmtrogiup();
            ftg.ShowDialog();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmtrogiup ftg = new frmtrogiup();
            ftg.ShowDialog();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {

        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            frmbaocao fbc = new frmbaocao();
            fbc.ShowDialog();
        }

        private void menuItem20_Click(object sender, EventArgs e)
        {
            fRMBCphongban fbc1 = new fRMBCphongban();
            fbc1.ShowDialog();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmcoban fcb = new frmcoban();
            fcb.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            ftk.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmtrogiup ftg = new frmtrogiup();
            ftg.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            fdm.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmchedo fcc = new frmchedo();
            fcc.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmdangki dk = new frmdangki();
            dk.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            fpb.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            frb.ShowDialog();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ftcn = new frmthongtincanhan();
            ftcn.ShowDialog();
        }
        public void Hienngay(ref string Ngaythangnam, ref string Gio, ref string timeofday)
        {
            string[] a = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] b = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string[] c = { "AM", "PM" };
            string[] d = { "Sáng", "Chiều" };
            string thu = "";
            string tgngay = "";
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string thoigian = DateTime.Now.ToString().Substring(9, 9);
            //
            for (int i = 0; i < c.Length; i++)
            {
                if (DateTime.Now.ToString().Substring(DateTime.Now.ToString().Length - 2, 2).ToLower().Trim() == c[i].ToLower().Trim())
                { tgngay = d[i]; }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToLower().Trim() == a[i].ToLower().Trim())
                { thu = b[i]; }

            }
            Ngaythangnam = thu + ", " + ngay + "/" + thang + "/" + nam;
            Gio = thoigian;
            timeofday = tgngay;
        }
        private void toolStripButton13_Click(object sender, EventArgs e)
        {

        }

    }
}
