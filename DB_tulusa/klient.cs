using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Pdf;
using SautinSoft.Document;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;

namespace DB_tulusa
{
    public partial class klient : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kat;
        TabControl kategooriad;
        SqlDataAdapter failinimi_adap;
        PictureBox pictureBox;
        Random s = new Random();
        public klient()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        Document document;
        Random rnd = new Random();
        private void Tsekk_btn_Click(object sender, EventArgs e)
        {
            document = new Document();//using Aspose.Pdf
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode      Hind      Kogus      Summa"));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
            }
            int num = rnd.Next(0, 99999);
            document.Save(@"C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\Arved\" + num + ".pdf");
            document.Dispose();
            System.Diagnostics.Process.Start(@"C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\Arved\" + num + ".pdf");
        }
        int Id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //если выбрать пустую строку, то будет ошибка
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            test_lbl.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kogus_num.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            hind_num.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            try
            {
                toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Sellel toodel pilt on otsas");
                toode_pbox.Image = Image.FromFile("../../Images/file.png");
            }
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        List<string> Tooded_list = new List<string>();
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            Tooded_list.Add("___________________________________");
            if (checkBox2.Checked == true)
            {
                double kott = 0.30;
                if (checkBox1.Checked == true)
                {
                    double sodus = (s.Next(50) / 100.0);
                    Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (kott + sodus * Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString())).ToString() + "             " + sodus + "             " + kott));
                }
                else if (checkBox1.Checked == false)
                {
                    Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (kott + Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString()))).ToString() + "             " + kott);
                }
            }
            else if (checkBox2.Checked == false)
            {
                Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString()))).ToString());
            }
            //Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString()))).ToString());
        }
        private void Kustuta_btn_Click(object sender, EventArgs e)
        {
            Tooded_list.Clear();
        }
        public void Naita_Andmed()
        {
            string kogus = kogus_num.Value.ToString();
            string hind = hind_num.Value.ToString();
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodenimetus,Kogus,Hind FROM Toodetable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            toode_pbox.Image = Image.FromFile("../../Images/file.png");
            connect.Close();
        }
    }
}