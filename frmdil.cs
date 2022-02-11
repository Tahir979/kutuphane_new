using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane
{
    public partial class frmdil : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;

        public frmdil()
        {
            InitializeComponent();
        }
        void griddoldur2()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("Select * from dil", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "dil");
            dataGridView1.DataSource = ds.Tables["dil"];
            con.Close();
        }
        void Xyz()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from dil"
            };
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_kitaplıkismiekle.Items.Add(reader[Localization.Ad]);
            }
        }
        private void frmdil_Load(object sender, EventArgs e)
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
                DialogResult x = MessageBox.Show("Dil eklemek istediğinizden emin misiniz?", Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = "insert into dil(Ad) values (@Ad)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Dil ekleme başarılı.", Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();
                    textBox1.Clear();

                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.txt_dgskontrol.Text = "1";

                    frm.Griddoldur_dil();
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
                DialogResult x = MessageBox.Show("Dil silmek istediğinizden emin misiniz?", Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = "Delete From dil Where Ad=@Ad";
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, cmb_kitaplıkismiekle.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Dil silme başarılı.", Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();

                    Form1 frm = (Form1)Application.OpenForms["Form1"];
                    frm.txt_dgskontrol.Text = "1";

                    frm.Griddoldur_dil();
                }
            }
        }
    }
}
