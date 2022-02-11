using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class frmkitaplik : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;

        public frmkitaplik()
        {
            InitializeComponent();
        }
        void griddoldur2()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("Select * from kitaplik", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkitaplik);
            dataGridView1.DataSource = ds.Tables[Localization.frmkitaplik];
            con.Close();
        }
        void Xyz()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from kitaplik"
            };
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_kitaplıkismiekle.Items.Add(reader[Localization.Ad]);
            }
        }
        private void frmkitaplik_Load(object sender, EventArgs e)
        {
            Xyz();
        }
        private void btn_kitaplıkismiekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult x = MessageBox.Show(Localization.frmkitaplik_kesinles, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = "insert into kitaplik(Ad) values (@Ad)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Localization.frmkitaplik_mb1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();
                    textBox1.Clear();

                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.txt_dgskontrol.Text = "1";

                    frm.Griddoldur_kitaplik();
                }
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_kitaplıkismiekle.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult x = MessageBox.Show(Localization.frmkitapliksil_kesinles, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = "Delete From kitaplik Where Ad=@Ad";
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, cmb_kitaplıkismiekle.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Localization.frmkitaplik_Sil_2, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();

                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.txt_dgskontrol.Text = "1";

                    frm.Griddoldur_kitaplik();
                }
            }
        }
    }
}
