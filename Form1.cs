using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;

namespace Kütüphane
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbDataAdapter da2;
        OleDbDataAdapter da3;
        OleDbDataAdapter da4;
        DataSet ds;
        DataSet ds2;
        DataSet ds3;
        DataSet ds4;


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect *from kitap Order By isim ASC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkisi_kitap);
            metroGrid1.DataSource = ds.Tables[Localization.frmkisi_kitap];
            con.Close();
        }
        public void Griddoldur_kitaplik()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da2 = new OleDbDataAdapter("Select * from kitaplik", con);
            ds2 = new DataSet();
            con.Open();
            da2.Fill(ds2, Localization.frmkitaplik);
            data_kitaplik.DataSource = ds2.Tables[Localization.frmkitaplik];
            con.Close();

            if(txt_kontrol.Text == "arama")
            {
                cmb_kitaplik_ara.Items.Clear();

                for (int i = 0; i < data_kitaplik.Rows.Count - 1; i++)
                {
                    cmb_kitaplik_ara.Items.Add(data_kitaplik.Rows[i].Cells[0].Value.ToString());
                }
            }
            else if(txt_kontrol.Text == "düzenleme")
            {
                cmb_kitaplik.Items.Clear();

                for (int i = 0; i < data_kitaplik.Rows.Count - 1; i++)
                {
                    cmb_kitaplik.Items.Add(data_kitaplik.Rows[i].Cells[0].Value.ToString());
                }
            }
            else
            {
                cmb_kitaplik_ara.Items.Clear();
                cmb_kitaplik.Items.Clear();

                for (int i = 0; i < data_kitaplik.Rows.Count - 1; i++)
                {
                    cmb_kitaplik.Items.Add(data_kitaplik.Rows[i].Cells[0].Value.ToString());
                    cmb_kitaplik_ara.Items.Add(data_kitaplik.Rows[i].Cells[0].Value.ToString());
                }
            }

            cmb_kitaplik.BackColor = Color.White;
            cmb_kitaplik.ForeColor = Color.Black;
        }
        public void Griddoldur_dil()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da3 = new OleDbDataAdapter("Select * from dil Order By sayi DESC", con);
            ds3 = new DataSet();
            con.Open();
            da3.Fill(ds3, "dil");
            data_dil.DataSource = ds3.Tables["dil"];
            con.Close();

            if (txt_kontrol.Text == "arama")
            {
                cmb_dil_ara.Items.Clear();

                for (int i = 0; i < data_dil.Rows.Count - 1; i++)
                {
                    cmb_dil_ara.Items.Add(data_dil.Rows[i].Cells[0].Value.ToString());
                }
            }
            else if (txt_kontrol.Text == "düzenleme")
            {
                cmb_dil.Items.Clear();

                for (int i = 0; i < data_dil.Rows.Count - 1; i++)
                {
                    cmb_dil.Items.Add(data_dil.Rows[i].Cells[0].Value.ToString());
                }
            }
            else
            {
                cmb_dil_ara.Items.Clear();
                cmb_dil.Items.Clear();

                for (int i = 0; i < data_dil.Rows.Count - 1; i++)
                {
                    cmb_dil.Items.Add(data_dil.Rows[i].Cells[0].Value.ToString());
                    cmb_dil_ara.Items.Add(data_dil.Rows[i].Cells[0].Value.ToString());
                }
            }

            cmb_dil.BackColor = Color.White;
            cmb_dil.ForeColor = Color.Black;
        }
        public void Griddoldur_yapi()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da4 = new OleDbDataAdapter("Select * from yapi", con);
            ds4 = new DataSet();
            con.Open();
            da4.Fill(ds4, "yapi");
            data_yapi.DataSource = ds4.Tables["yapi"];
            con.Close();

            cmb_kat.Items.Clear();

            for (int i = 0; i < data_yapi.Rows.Count - 1; i++)
            {
                cmb_kat.Items.Add(data_yapi.Rows[i].Cells[0].Value.ToString());
            }

            cmb_kat.BackColor = Color.White;
            cmb_kat.ForeColor = Color.Black;
        }
        void datagridtsrm()
        {
            metroGrid1.Columns[0].HeaderText = "İsim";
            metroGrid1.Columns[1].HeaderText = "Yazar";
            metroGrid1.Columns[2].HeaderText = "Yıl";
            metroGrid1.Columns[3].HeaderText = "Dil";
            metroGrid1.Columns[4].HeaderText = "Kitaplık";
            metroGrid1.Columns[5].HeaderText = "Kat";
            metroGrid1.Columns[6].HeaderText = "Numara";

            metroGrid1.Columns[0].Width = 350;
            metroGrid1.Columns[1].Width = 150;
            metroGrid1.Columns[2].Width = 40;
            metroGrid1.Columns[3].Width = 70;
            metroGrid1.Columns[4].Width = 130;
            metroGrid1.Columns[5].Width = 30;
            metroGrid1.Columns[6].Width = 50;


            metroGrid1.DefaultCellStyle.BackColor = Color.White;
            metroGrid1.DefaultCellStyle.ForeColor = Color.Black;
            metroGrid1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255,0,148);
            metroGrid1.DefaultCellStyle.SelectionForeColor = Color.White;
            metroGrid1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            metroGrid1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            metroGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            metroGrid1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            metroGrid1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            metroGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            metroGrid1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);


            metroGrid1.Columns[7].Visible = false;
            metroGrid1.ClearSelection();

        }
        void mod_acik()
        {
            groupBox1.Enabled = true;
            btn_kaydet.Enabled = true;
            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;

            txt_isim.Enabled = true;
            txt_yazar.Enabled = true;
            txt_yil.Enabled = true;
            txt_numara.Enabled = true;

            btn_kaydet.Style = MetroFramework.MetroColorStyle.Blue;
            btn_guncelle.Style = MetroFramework.MetroColorStyle.Blue;
            btn_sil.Style = MetroFramework.MetroColorStyle.Blue;
        }
        void mod_kapali()
        {
            groupBox1.Enabled = false;
            btn_kaydet.Enabled = false;
            btn_guncelle.Enabled = false;
            btn_sil.Enabled = false;

            txt_isim.Enabled = false;
            txt_yazar.Enabled = false;
            txt_yil.Enabled = false;
            txt_numara.Enabled = false;

            btn_kaydet.Style = MetroFramework.MetroColorStyle.White;
            btn_guncelle.Style = MetroFramework.MetroColorStyle.White;
            btn_sil.Style = MetroFramework.MetroColorStyle.White;

            txt_id.Clear();
            txt_kontrol.Clear();
            txt_dgskontrol.Clear();
        }
        void dt_dt1_void2()
        {
            if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//1
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "isim Like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or yazar Like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//2
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//3
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or " +
                    "yil Like '%" + txt_yil1.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//4
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or " +
                    "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//5
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//6
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "yil Like '%" + txt_yil1.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//7
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text == string.Empty)//8
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//9
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//10
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//11
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//12
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//13
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//14
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_yil1.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//15
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "dil Like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text != string.Empty)//16
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text != string.Empty)//17
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "isim Like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or yazar Like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text != string.Empty)//18
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "dil Like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text != string.Empty)//19
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text != string.Empty)//20
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text != string.Empty)//21
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' or " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text != string.Empty)//22
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text != string.Empty && txt_yil1.Text != string.Empty && cmb_dil_ara.Text != string.Empty && txt_ara.Text != string.Empty && txt_yil2.Text != string.Empty)//23
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where yil BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", txt_yil1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", txt_yil2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                metroGrid1.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "isim like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%' or " +
                    "rafismi Like '%" + cmb_kitaplik_ara.Text + "%' and " +
                    "yazar like '%" + txt_ara.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_dil_ara.Text + "%'";
                metroGrid1.DataSource = dv;

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();
            }
            else if (cmb_kitaplik_ara.Text == string.Empty && txt_yil1.Text == string.Empty && cmb_dil_ara.Text == string.Empty && txt_ara.Text == string.Empty && txt_yil2.Text == string.Empty)//24
            {
                Griddoldur();

                lbl_uygun.Text = metroGrid1.Rows.Count.ToString();

                metroGrid1.ClearSelection();
            }
        }
        void sayi_tüm()
        {
            int x;
            x = metroGrid1.RowCount;
            string y = x.ToString();
            lbl_tüm.Text = y;
        }
        void temizle()
        {
            txt_isim.Clear();
            txt_yazar.Clear();
            txt_yil.Clear();
            cmb_dil.Text = "";
            cmb_kitaplik.Text = "";
            cmb_kat.Text = "";
            txt_numara.Clear();
            txt_id.Clear();
        }
        void kaydet()
        {
            try
            {
                string y1 = Localization.oledbcon;
                OleDbConnection baglanti1 = new OleDbConnection(y1);
                baglanti1.Open();
                string ekle1 = "insert into kitap (isim,yazar,yil,dil, rafismi,rafkati,rafnumarasi) values (@Kitabinİsmi,@KitabinYazari,@KitabınBasımYılı,@dil,@KitabınRafınınİsmi,@KitabınRafKatı,@KitabınRafNumarası)";
                OleDbCommand komut1 = new OleDbCommand(ekle1, baglanti1);

                if (txt_yazar.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_isim.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, "-");
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_yil.Text);

                    komut1.Parameters.AddWithValue(Localization.dil_et, cmb_dil.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplik.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_kat.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_numara.Text);

                    komut1.ExecuteNonQuery();
                }
                else if (txt_yil.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_isim.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, "-");

                    komut1.Parameters.AddWithValue(Localization.dil_et, cmb_dil.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplik.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_kat.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_numara.Text);

                    komut1.ExecuteNonQuery();
                }
                else if (txt_yazar.Text == "" && txt_yil.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_isim.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, "-");
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, "-");

                    komut1.Parameters.AddWithValue(Localization.dil_et, cmb_dil.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplik.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_kat.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_numara.Text);

                    komut1.ExecuteNonQuery();
                }
                else
                {
                    komut1.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_isim.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_yil.Text);

                    komut1.Parameters.AddWithValue(Localization.dil_et, cmb_dil.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplik.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_kat.Text);
                    komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_numara.Text);

                    komut1.ExecuteNonQuery();
                }


                baglanti1.Close();
            }
            catch
            {
                MessageBox.Show("Kaydetme kodlarında bir hata meydana geldi, eğer bu hatayı sürekli alıyorsanız lütfen muhammettahirtekatli@gmail.com ile iletişime geçiniz ya da c#'dan anlayan birine durumu bildiriniz ve breakpoint kullanarak hatayı tespit etmesi gerektiğini söyleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void guncelle()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "update kitap set isim=@isim, yazar=@yazar, yil=@yil, dil=@dil, rafismi=@rafismi, rafkati=@rafkati, rafnumarasi=@rafnumarasi where ID=@ID";

                cmd.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_isim.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_yil.Text);
                cmd.Parameters.AddWithValue(Localization.dil_et, cmb_dil.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplik.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_kat.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_numara.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_id.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Güncelleme kodlarında bir hata meydana geldi, eğer bu hatayı sürekli alıyorsanız lütfen muhammettahirtekatli@gmail.com ile iletişime geçiniz ya da c#'dan anlayan birine durumu bildiriniz ve breakpoint kullanarak hatayı tespit etmesi gerektiğini söyleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void sil()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM kitap WHERE ID=@ID";

                cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_id.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Silme kodlarında bir hata meydana geldi, eğer bu hatayı sürekli alıyorsanız lütfen muhammettahirtekatli@gmail.com ile iletişime geçiniz ya da c#'dan anlayan birine durumu bildiriniz ve breakpoint kullanarak hatayı tespit etmesi gerektiğini söyleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void şıklatbeni()
        {
            Griddoldur();
            sayi_tüm();

            metroGrid1.ClearSelection();
            metroTile1.PerformClick();

            temizle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mod_kapali();
            Griddoldur();
            Griddoldur_dil();
            Griddoldur_kitaplik();
            Griddoldur_yapi();
            datagridtsrm();

            lbl_tüm.Text = metroGrid1.Rows.Count.ToString();

            txt_yil.MaxLength = 4;
            txt_numara.MaxLength = 4;

            lbl_kütüphanedüzen.DisplayFocus = false;
        }
        private void lnk_kitaplik_Click(object sender, EventArgs e)
        {
            frmkitaplik x = new frmkitaplik();
            x.Show();
        }
        private void lnk_dil_Click(object sender, EventArgs e)
        {
            frmdil x = new frmdil();
            x.Show();
        }
        private void lnk_yapi_Click(object sender, EventArgs e)
        {
            frmyapi x = new frmyapi();
            x.Show();
        }
        private void cmb_kitaplık_MouseEnter(object sender, EventArgs e)
        {
            if (txt_dgskontrol.Text == "1")
            {
                Griddoldur_kitaplik();

                txt_dgskontrol.Text = "";
            }
        }
        private void cmb_dil_MouseEnter(object sender, EventArgs e)
        {
            if (txt_dgskontrol.Text == "1")
            {
                Griddoldur_dil();

                txt_dgskontrol.Text = "";
            }
        }
        private void cmb_kat_MouseEnter(object sender, EventArgs e)
        {
            if (txt_dgskontrol.Text == "1")
            {
                Griddoldur_yapi();

                txt_dgskontrol.Text = "";
            }
        }
        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            metroGrid1.ClearSelection();

            if(txt_ara.Text == "" && cmb_kitaplik_ara.Text == "" && txt_yil1.Text == "" && txt_yil2.Text == "" && cmb_dil_ara.Text == "")
            {
                lbl_uygun.Text = "";
            }
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            metroGrid1.ClearSelection();

            if (txt_ara.Text == "" && cmb_kitaplik_ara.Text == "" && txt_yil1.Text == "" && txt_yil2.Text == "" && cmb_dil_ara.Text == "")
            {
                lbl_uygun.Text = "";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            metroGrid1.ClearSelection();

            if (txt_ara.Text == "" && cmb_kitaplik_ara.Text == "" && txt_yil1.Text == "" && txt_yil2.Text == "" && cmb_dil_ara.Text == "")
            {
                lbl_uygun.Text = "";
            }
        }
        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_yil2.Visible = true;
        }
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_yil2.Visible = false;
        }
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked == true)
            {
                mod_acik();
            }
            else
            {
                if (txt_isim.Text != "" || txt_yazar.Text != "" || txt_yil.Text != "" || txt_numara.Text != "" || cmb_dil.Text != "" || cmb_kat.Text != "" || cmb_kitaplik.Text != "")
                {
                    metroCheckBox1.Checked = true;
                    MessageBox.Show("Lütfen mevcut düzenleme işleminizi bitiriniz/sonlandırınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mod_kapali();
                    metroCheckBox1.Checked = false;
                }
            }
        }
        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (txt_islemler.Text == "k")
            {
                kaydet();
                şıklatbeni();
            }
            else if (txt_islemler.Text == "g")
            {
                guncelle();
                şıklatbeni();
            }
            else if (txt_islemler.Text == "s")
            {
                sil();
                şıklatbeni();
            }
            txt_islemler.Text = "";

            cmb_sahtedil.Width = 146;
            cmb_sahtedil.Location = new Point(74, 121);
            cmb_sahtedil.Visible = true;
            cmb_dil.Visible = false;

            cmb_sahtekitaplik.Width = 146;
            cmb_sahtekitaplik.Location = new Point(74, 156);
            cmb_sahtekitaplik.Visible = true;
            cmb_kitaplik.Visible = false;

            cmb_sahtekat.Width = 146;
            cmb_sahtekat.Location = new Point(74, 191);
            cmb_sahtekat.Visible = true;
            cmb_kat.Visible = false;

            if (txt_hayir.Text == "hayir")
            {

            }
            else if(txt_hayir.Text == "")
            {
                cmb_dil.Items.Clear();
                Griddoldur_dil();

                cmb_kitaplik.Items.Clear();
                Griddoldur_kitaplik();

                cmb_kat.Items.Clear();
                Griddoldur_yapi();
            }
            txt_hayir.Text = "";



            txt_kontrol.Text = "düzenleme";

            txt_isim.Clear();
            txt_yazar.Clear();
            txt_yil.Clear();
            txt_numara.Clear();
            txt_id.Clear();

            metroGrid1.ClearSelection();
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            txt_kontrol.Text = "arama";

            txt_ara.Clear();
            txt_yil2.Clear();
            txt_yil1.Clear();

            cmb_kitaplik_ara.Items.Clear();
            Griddoldur_kitaplik();

            cmb_dil_ara.Items.Clear();
            Griddoldur_dil();

            cmb_sahtekitaplik_ara.Width = 146;
            cmb_sahtekitaplik_ara.Location = new Point(119,51);
            cmb_sahtekitaplik_ara.Visible = true;
            cmb_kitaplik_ara.Visible = false;

            cmb_sahtedil_ara.Width = 146;
            cmb_sahtedil_ara.Location = new Point(119, 156);
            cmb_sahtedil_ara.Visible = true;
            cmb_dil_ara.Visible = false;

            lbl_uygun.Text = "";
            metroRadioButton1.Checked = true;
            metroRadioButton2.Checked = false;
            //neden kutu 2'yi kapatmadık peki?
            //kapattık artık ya
            Griddoldur();
            metroGrid1.ClearSelection();
        }
        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_yil1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_yil2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_yil1_TextChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            metroGrid1.ClearSelection();

            if (txt_ara.Text == "" && cmb_kitaplik_ara.Text == "" && txt_yil1.Text == "" && txt_yil2.Text == "" && cmb_dil_ara.Text == "")
            {
                lbl_uygun.Text = "";
            }
        }
        private void txt_yil2_TextChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            metroGrid1.ClearSelection();

            if (txt_ara.Text == "" && cmb_kitaplik_ara.Text == "" && txt_yil1.Text == "" && txt_yil2.Text == "" && cmb_dil_ara.Text == "")
            {
                lbl_uygun.Text = "";
            }
        }
        private void metroLink7_Click(object sender, EventArgs e)
        {
            metroGrid1.Columns[0].Width = 350;
            metroGrid1.Columns[1].Width = 150;
            metroGrid1.Columns[2].Width = 40;
            metroGrid1.Columns[3].Width = 70;
            metroGrid1.Columns[4].Width = 130;
            metroGrid1.Columns[5].Width = 30;
            metroGrid1.Columns[6].Width = 50;

            metroGrid1.Sort(metroGrid1.Columns[0], ListSortDirection.Ascending);
            metroGrid1.ClearSelection();
        }
        private void cmb_sahtekitaplik_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_sahtekitaplik_ara.Visible = false;
            cmb_kitaplik_ara.Visible = true;
        }
        private void cmb_sahtedil_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_sahtedil.Visible = false;
            cmb_dil.Visible = true;
        }
        private void cmb_sahtekitaplik_MouseMove_1(object sender, MouseEventArgs e)
        {
            cmb_sahtekitaplik.Visible = false;
            cmb_kitaplik.Visible = true;
        }
        private void cmb_sahtedil_ara_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_sahtedil_ara.Visible = false;
            cmb_dil_ara.Visible = true;
        }
        private void cmb_sahtekat_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_sahtekat.Visible = false;
            cmb_kat.Visible = true;
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_kitaplik.Text) == true || string.IsNullOrEmpty(cmb_kat.Text) == true || string.IsNullOrEmpty(txt_numara.Text) == true || string.IsNullOrEmpty(cmb_dil.Text))
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == false)
            {
                MessageBox.Show(Localization.frmekle_ekle_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Kitap eklemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new göz().ShowDialog()).Start();

                    txt_islemler.Text = "k";
                    txt_hayir.Text = "hayir";
                    metroTile4.PerformClick();

                    göz f = new göz();
                    f = (göz)Application.OpenForms["göz"];
                    f.Close();

                    txt_isim.Focus();

                    MessageBox.Show(Localization.frmekle_ekle_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Herhangi bir işlem yapılmadı.");
                }
            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_kitaplik.Text) == true || string.IsNullOrEmpty(cmb_kat.Text) == true || string.IsNullOrEmpty(txt_numara.Text) == true || string.IsNullOrEmpty(cmb_dil.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == true)
            {
                MessageBox.Show(Localization.frmekle_guncelle_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_isim.Text == metroGrid1.CurrentRow.Cells[0].Value.ToString() && txt_yazar.Text == metroGrid1.CurrentRow.Cells[1].Value.ToString() && txt_yil.Text == metroGrid1.CurrentRow.Cells[2].Value.ToString() && txt_numara.Text == metroGrid1.CurrentRow.Cells[5].Value.ToString() && cmb_dil.Text == metroGrid1.CurrentRow.Cells[7].Value.ToString() && cmb_kitaplik.Text == metroGrid1.CurrentRow.Cells[3].Value.ToString() && cmb_kat.Text == metroGrid1.CurrentRow.Cells[4].Value.ToString())
            {
                MessageBox.Show(Localization.gfhfd, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Kitabı güncellemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new göz().ShowDialog()).Start();

                    txt_islemler.Text = "g";
                    txt_hayir.Text = "hayir";
                    metroTile4.PerformClick();

                    göz f = new göz();
                    f = (göz)Application.OpenForms["göz"];
                    f.Close();

                    txt_isim.Focus();

                    MessageBox.Show(Localization.frmekle_guncelle_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information); //catch kısmı
                }
                else
                {
                    MessageBox.Show("Herhangi bir işlem yapılmadı.");
                }
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_kitaplik.Text) == true || string.IsNullOrEmpty(cmb_kat.Text) == true || string.IsNullOrEmpty(txt_numara.Text) == true || string.IsNullOrEmpty(cmb_dil.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == true)
            {
                MessageBox.Show(Localization.frmekle_sil_uyari2, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Kitabı silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new göz().ShowDialog()).Start();

                    txt_islemler.Text = "s";
                    txt_hayir.Text = "hayir";
                    metroTile4.PerformClick();

                    göz f = new göz();
                    f = (göz)Application.OpenForms["göz"];
                    f.Close();

                    txt_isim.Focus();

                    MessageBox.Show(Localization.frmekle_sil_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information); //catch kısmı*/
                }
                else
                {
                    MessageBox.Show("Herhangi bir işlem yapılmadı.");
                }
            }
        }
        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if(metroCheckBox1.Checked == false)
            {

            }
            else
            {
                txt_isim.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
                txt_yazar.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
                txt_yil.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                cmb_dil.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                cmb_kitaplik.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
                cmb_kat.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
                txt_numara.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                txt_id.Text = metroGrid1.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void label_düzen_Click(object sender, EventArgs e)
        {
            frmdüzen x = new frmdüzen();
            x.Show();
        }
        private void label_arama_Click(object sender, EventArgs e)
        {
            frmarama x = new frmarama();
            x.Show();
        }
        private void lbl_kütüphanedüzen_Click(object sender, EventArgs e)
        {
            frmkütüphanedüzeni x = new frmkütüphanedüzeni();
            x.Show();
        }
        private void lbl_diğerkonular_Click(object sender, EventArgs e)
        {
            frmdiğerkonular x = new frmdiğerkonular();
            x.Show();
        }
        private void lbl_credits_Click(object sender, EventArgs e)
        {
            frmcredits x = new frmcredits();
            x.Show();
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            kural x = new kural();
            x.Show();
        }
        private void txt_numara_Leave(object sender, EventArgs e)
        {
            btn_kaydet.Focus();
        }
        private void metroLink1_Leave(object sender, EventArgs e)
        {
            txt_ara.Focus();
        }
        private void btn_sil_Leave(object sender, EventArgs e)
        {
            lbl_kütüphanedüzen.DisplayFocus = true;
        }
        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            txt_isim.Focus();
        }
        private void metroTile4_Leave(object sender, EventArgs e)
        {
            txt_isim.Focus();
        }
        private void metroGrid1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroGrid1.ClearSelection();
            metroTile4.PerformClick();
        }
    }
}
