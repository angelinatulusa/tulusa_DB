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

namespace DB_tulusa
{
    public partial class algus : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\AppData\Tooded_DB.mdf;Integrated Security=True");
        TextBox login, parol;
        Label login_lbl, parol_lbl;
        Button edasi, tagasi;
        CheckBox muuja_cbox,omanik_cbox,kasutaja_cbox;
        public algus()
        {
            InitializeComponent();
            login = new TextBox
            {
                Size = new System.Drawing.Size(214, 29),
                Location = new System.Drawing.Point(215, 35),
                BackColor = System.Drawing.Color.LightGray,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186))),
            }; ;
            parol = new TextBox
            {
                Size = new System.Drawing.Size(214, 29),
                Location = new System.Drawing.Point(215, 100),
                BackColor = System.Drawing.Color.LightGray,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186))),
            };
            login_lbl = new Label
            {
                Text = "login:",
                Size = new System.Drawing.Size(118, 27),
                Location = new System.Drawing.Point(215, 0),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186))),
            };
            parol_lbl = new Label
            {
                Text = "parol:",
                Size = new System.Drawing.Size(118, 27),
                Location = new System.Drawing.Point(215, 70),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186))),
            };
            edasi = new Button
            {
                Text = "edasi",
                Size = new System.Drawing.Size(130, 30),
                Location = new System.Drawing.Point(225, 155),
                BackColor = System.Drawing.Color.LightSkyBlue,
                Font = new Font("Arial", 15, FontStyle.Bold),
            };
            tagasi = new Button
            {
                Text = "tagasi",
                Size = new System.Drawing.Size(130, 30),
                Location = new System.Drawing.Point(225, 200),
                BackColor = System.Drawing.Color.LightCoral,
                Font = new Font("Arial", 15, FontStyle.Bold),
            };
            muuja_cbox = new CheckBox { }; omanik_cbox = new CheckBox { }; kasutaja_cbox = new CheckBox { };
        }

        private void klient_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(login);
            this.Controls.Add(parol);
            this.Controls.Add(login_lbl);
            this.Controls.Add(parol_lbl);
            this.Controls.Add(edasi);
            this.Controls.Add(tagasi);
            kasutaja_cbox.Checked = true;
            edasi.Click += Edasi2_Click;
            tagasi.Click += Tagasi_Click;
        }

        private void Tagasi_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(muuja_btn);
            this.Controls.Add(klient_btn);
            this.Controls.Add(omanik_btn);
            muuja_btn.Click += muuja_btn_Click;
            klient_btn.Click += klient_btn_Click;
            omanik_btn.Click += omanik_btn_Click;
        }

        private void muuja_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(login);
            this.Controls.Add(parol);
            this.Controls.Add(login_lbl);
            this.Controls.Add(parol_lbl);
            this.Controls.Add(edasi);
            this.Controls.Add(tagasi);
            muuja_cbox.Checked = true;
            edasi.Click+= Edasi2_Click;
            tagasi.Click += Tagasi_Click;
        }
        private void omanik_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(login);
            this.Controls.Add(parol);
            this.Controls.Add(login_lbl);
            this.Controls.Add(parol_lbl);
            this.Controls.Add(edasi);
            this.Controls.Add(tagasi);
            omanik_cbox.Checked = true;
            edasi.Click += Edasi2_Click;
            tagasi.Click += Tagasi_Click;

        }
        private void Edasi2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kasutaja where login=@nimi and parol=@parool and roll=@roll", connect);
            if (muuja_cbox.Checked == true)
            {
                cmd.Parameters.AddWithValue("@roll", "muuja");
                cmd.Parameters.AddWithValue("@nimi", login.Text);
                cmd.Parameters.AddWithValue("@parool", parol.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("OLED SEES");

                    kassa muuja = new kassa();
                    muuja.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vale,proovige uuesti");
                }
            }
            else if (omanik_cbox.Checked == true)
            {
                cmd.Parameters.AddWithValue("@roll", "omanik");
                cmd.Parameters.AddWithValue("@nimi", login.Text);
                cmd.Parameters.AddWithValue("@parool", parol.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("OLED SEES");

                    Form1 omanik = new Form1();
                    omanik.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vale,proovige uuesti");
                }
            }
            else if (kasutaja_cbox.Checked == true)
            {
                cmd.Parameters.AddWithValue("@roll", "kasutaja");
                cmd.Parameters.AddWithValue("@nimi", login.Text);
                cmd.Parameters.AddWithValue("@parool", parol.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("OLED SEES");

                    klient Klient = new klient();
                    Klient.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vale,proovige uuesti");
                }
            }
        }
        private void Edasi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kasutaja where login=@nimi and parol=@parool", connect);
            cmd.Parameters.AddWithValue("@nimi", login.Text);
            cmd.Parameters.AddWithValue("@parool", parol.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("OLED SEES");

                klient Klient = new klient();
                Klient.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vale,proovige uuesti");
            }
        }
    }
}
