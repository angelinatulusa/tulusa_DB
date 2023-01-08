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

namespace DB_tulusa
{
    public partial class kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kat;
        SqlCommand cmd; 
        Random s = new Random();
        public kassa()
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
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode      Hind      Kogus      Summa      Sodus"));
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
            Kat_cbox.SelectedIndex = int.Parse(v) - 1;
            cmd = new SqlCommand("UPDATE Toodetable SET kogus=@kogus WHERE Toodenimetus=@nimi", connect);

            connect.Open();
            string toodenimi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmd.Parameters.AddWithValue("@nimi", toodenimi);
            int count = (int)kogus_num.Value;
            int kogus = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) - count;
            cmd.Parameters.AddWithValue("@kogus", kogus);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        List<string> Tooded_list = new List<string>();
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            Tooded_list.Add("___________________________________________");

            if (checkBox1.Checked==true)
            {
                double sodus = (s.Next(50) / 100.0);
                Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (sodus * Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString())).ToString() + "             " + sodus));
            }
            else if (checkBox1.Checked == false)
            {
                Tooded_list.Add((test_lbl.Text + "             " + hind_num.Text + "             " + kogus_num.Text + "             " + (Convert.ToInt32(kogus_num.Text.ToString()) * Convert.ToInt32(hind_num.Text.ToString()))).ToString());
            }
            
    
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
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            toode_pbox.Image = Image.FromFile("../../Images/file.png");
            connect.Close();
            Naita_Kat();
        }
        private void kus_btn_Click(object sender, EventArgs e)
        {
            string sql = "";
            DialogResult result = MessageBox.Show("Kustuta kategooria?(Ei=kustuta toode)", "...", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                connect.Open();
                if (dataGridView1.SelectedRows.Count == 0) return;
                sql = "DELETE FROM Toodetable WHERE Id=@rowID";

                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                connect.Close();
            }
            else if (result == DialogResult.Yes)
            {
                connect.Open();
                if (Kat_cbox.Text == "") return;
                sql = "DELETE FROM Kategooria WHERE Kategooria_nimetus=@kat";

                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    deleteRecord.Parameters.AddWithValue("@kat", Kat_cbox.Text);
                    deleteRecord.ExecuteNonQuery();
                }
                Kustuta_andmed();
                connect.Close();
                Naita_Kat();
            }

        }
        public void Kustuta_andmed()
        {
            test_lbl.Text = " ";
            kogus_num.Value = 0;
            hind_num.Value = 0;
            Kat_cbox.Items.Clear();
        }

        private void kassa_btn_Click(object sender, EventArgs e)
        {
            kat kassa = new kat();
            kassa.ShowDialog();
        }

        public void Naita_Kat()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus from Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kat_cbox.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }
    }
}
