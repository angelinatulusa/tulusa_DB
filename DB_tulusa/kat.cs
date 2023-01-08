﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_tulusa
{
    public partial class kat : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zara\source\repos\tulusa_DB\DB_tulusa\AppData\Tooded_DB.mdf;Integrated Security=True");
        //
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        TabControl kategooriad;
        SqlDataAdapter failinimi_adap;
        PictureBox pictureBox;
        public kat()
        {
            this.Size = new System.Drawing.Size(600, 300);
            Kategooriad();
            //Tooded();


        }
        TableLayoutPanel tlp;



        public void Tooded(int kat_Id)
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter_toode.Fill(dt_toode);

            tlp = new TableLayoutPanel();
            foreach (DataRow toode in dt_toode.Rows)
            {
                //PictureBox pbox=new PictureBox.Image.Add.FromFile("../../Images/about.png");
            }

            connect.Close();

        }
        int kat_Id;
        string failid;

        List<string> fail_list;
        public List<string> Failid_KatId(int kat_Id)
        {
            fail_list = new List<string>();
            failinimi_adap = new SqlDataAdapter("SELECT Pilt FROM Toodetable WHERE Kategooria_Id=" + kat_Id, connect);
            //kat_Id_adap.MissingSchemaAction = MissingSchemaAction.Add;
            DataTable failid = new DataTable();
            failinimi_adap.Fill(failid);
            foreach (DataRow fail in failid.Rows)
            {
                fail_list.Add(fail["Pilt"].ToString());
            }
            return fail_list;
        }
        public void Kategooriad()
        {
            kategooriad = new TabControl();
            kategooriad.Name = "Kategooriad";
            kategooriad.Dock = DockStyle.Left;
            kategooriad.Width = this.Width;
            kategooriad.Height = this.Height;

            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);

            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            ImageList iconsList = new ImageList();//
            iconsList.ColorDepth = ColorDepth.Depth32Bit;//
            iconsList.ImageSize = new Size(25, 25);//

            int i = 0;//
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                kategooriad.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
                iconsList.Images.Add(Image.FromFile(@"..\..\kat_pildid\" + (string)nimetus["Kategooria_nimetus"] + ".jpg"));//
                kategooriad.TabPages[i].ImageIndex = i;//
                i++;//
                kat_Id = (int)nimetus["Id"];
                fail_list = Failid_KatId(kat_Id);
                int r = 0;
                int c = 0;
                foreach (var fail in fail_list)
                {
                    pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail);
                    pictureBox.Width = pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new Point(r, c);
                    r = r + 100 + 2;
                    kategooriad.TabPages[i - 1].Controls.Add(pictureBox);

                }
            }
            kategooriad.ImageList = iconsList;//
            connect.Close();
            this.Controls.Add(kategooriad);
        }
    }
}
