using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonetimMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            dgv_yonetim.Rows.Clear();

            dgv_yonetim.Rows.Add("Bölüm ve Masa Listesi");
            dgv_yonetim.Rows.Add("Ödeme Tip Listesi");
            dgv_yonetim.Rows.Add("İşletme Bilgileri");
            dgv_yonetim.Rows.Add("Müşteri Ekranı");
            dgv_yonetim.Rows.Add("Veritabanı Yedekleri");

            dgv_yonetim.ClearSelection();
        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            dgv_yonetim.Rows.Clear();

            dgv_yonetim.Rows.Add("Kategori Listesi");
            dgv_yonetim.Rows.Add("Ürün Listesi");
            dgv_yonetim.Rows.Add("Opsiyon Listesi");
            dgv_yonetim.Rows.Add("Ürün Fiyat Listesi");

            dgv_yonetim.ClearSelection();
        }

        private void btn_menuler_Click(object sender, EventArgs e)
        {
            dgv_yonetim.Rows.Clear();

            dgv_yonetim.Rows.Add("Menü Kategori Listesi");
            dgv_yonetim.Rows.Add("Menü Ürün Listesi");
            dgv_yonetim.Rows.Add("Menü Kategori İlişkileri");

            dgv_yonetim.ClearSelection();
        }

        private void btn_hareketler_Click(object sender, EventArgs e)
        {
            dgv_yonetim.Rows.Clear();

            dgv_yonetim.Rows.Add("Personel Hareketleri");
            dgv_yonetim.Rows.Add("İşlem Hareketleri");

            dgv_yonetim.ClearSelection();
        }

        private void btn_kullanıcılar_Click(object sender, EventArgs e)
        {
            dgv_yonetim.Rows.Clear();

            dgv_yonetim.Rows.Add("Rol Listesi");
            dgv_yonetim.Rows.Add("Kullanıcı Listesi");

            dgv_yonetim.ClearSelection();
        }

        private void tableLayoutPanel3_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle r = e.CellBounds;
            using (Pen pen = new Pen(Color.FromArgb(180, 190, 200)))
            {
                // top and left lines
                e.Graphics.DrawLine(pen, r.X, r.Y, r.X + r.Width, r.Y);
                e.Graphics.DrawLine(pen, r.X, r.Y, r.X, r.Y + r.Height);
                // last row? move hor.lines 1 up!
                int cy = e.Row == tableLayoutPanel1.RowCount - 1 ? -1 : 0;
                if (cy != 0) e.Graphics.DrawLine(pen, r.X, r.Y + r.Height + cy,
                                        r.X + r.Width, r.Y + r.Height + cy);
                // last column ? move vert. lines 1 left!
                int cx = e.Column == tableLayoutPanel1.ColumnCount - 1 ? -1 : 0;
                if (cx != 0) e.Graphics.DrawLine(pen, r.X + r.Width + cx, r.Y,
                                        r.X + r.Width + cx, r.Y + r.Height);
            }
        }

    }
}
