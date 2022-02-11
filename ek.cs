using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class ek
    {
        //ek kodlar
        /*int sayac = 0;
string[] dizi = new string[cmb_dil_kontrol.Items.Count];
for (int h = 0; h < cmb_dil_kontrol.Items.Count; h++)
{
    dizi[h] = cmb_dil_kontrol.Items[h].ToString();
}

for (int i = 0; i < cmb_dil_kontrol.Items.Count; i++)
{
    for (int j = 0; j < cmb_dil_kontrol.Items.Count; j++)
    {
        if(dizi[i] == dizi[j])
        {
            for (int l = 0; l < i; l++)
            {
                if(dizi[l] == dizi[i])
                {
                    sayac = -1;
                }
            }
            sayac++;
        }
    }

    if(sayac != 0)
    {
        lst_isim.Items.Add(dizi[i] + " dili" + sayac + " kez tekrar edilmiştir.");
    }

    sayac = 0;
}*/
        /*int[] sayilar = new int[cmb_dil_sayi.Items.Count];
for (int t = 0; t < cmb_dil_sayi.Items.Count; t++)
{
    sayilar[t] = Convert.ToInt32(cmb_dil_sayi.Items[t].ToString());
}
cmb_dil_sayi.Items.Clear();
Array.Reverse(sayilar);
foreach (int value in sayilar)
{
    cmb_dil_sayi.Items.Add(value);
}*/
        /*for (int i = 0; i < cmb_dil_kontrol.Items.Count; i++)
           {
               if (lst_isim.Items.Contains(cmb_dil_kontrol.Items[i].ToString()))
               {
                   for (int j = 0; j < cmb_dil_kontrol.Items.Count; j++)
                   {
                       if (cmb_dil_kontrol.Items[i] == cmb_dil_kontrol.Items[j])
                       {


                           DataView dv = ds.Tables[0].DefaultView;
                           dv.RowFilter = "nesne LIKE '" + cmb_dil_kontrol.Items[i].ToString() + "%'";
                           dataGridView2.DataSource = dv;

                           MessageBox.Show(dataGridView2.Rows[0].Cells[1].Value.ToString());
                           string deger = dataGridView2.Rows[0].Cells[1].Value.ToString(); //boş değer hocam diyor
                           int x = Convert.ToInt32(deger);
                           x++;





                           cmd = new OleDbCommand();
                           con.Open();
                           cmd.Connection = con;
                           cmd.CommandText = "update sayi set sayi=@sayi where nesne=@nesne";
                           cmd.Parameters.AddWithValue("@sayi", x);
                           cmd.Parameters.AddWithValue("@nesne", dataGridView2.Rows[0].Cells[0].Value.ToString());
                           cmd.ExecuteNonQuery();
                           griddoldur2();
                           cmb_dil.Text = Localization.bosdeger;
                           cmb_dil.Items.Clear();
                           Xyz();
                       }
                   }
               }
               else
               {
                   lst_isim.Items.Add(cmb_dil_kontrol.Items[i].ToString());

                   string vtyolu = Localization.oledbcon;
                   OleDbConnection baglanti = new OleDbConnection(vtyolu);
                   baglanti.Open();
                   string ekle = "insert into sayi(nesne) values (@nesne)";
                   OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                   komut.Parameters.AddWithValue("@nesne", cmb_dil_kontrol.Items[i].ToString());
                   komut.ExecuteNonQuery();
                   griddoldur2();
                   cmb_dil.Text = Localization.bosdeger;
                   cmb_dil.Items.Clear();
                   Xyz();
               }
           }*/
        /*string[] dizi = new string[cmb_dil.Items.Count];
for (int i = 0; i < cmb_dil.Items.Count; i++)
{
    dizi[i] = cmb_dil.Items[i].ToString();
}

cmb_dil.Items.Clear();

for (int h = 0; h < dizi.Length; h++)
{
    cmb_dil.Items.Add(dizi[h]);
}*/
        /*void Xyz()
{
    OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
    baglan.Open();
    OleDbCommand command = new OleDbCommand
    {
        Connection = baglan,
        CommandText = "select* from kitaplik"
    };
    OleDbCommand command2 = new OleDbCommand
    {
        Connection = baglan,
        CommandText = "select* from kitap"
    };
    OleDbCommand command3 = new OleDbCommand
    {
        Connection = baglan,
        CommandText = "select* from dil Order By sayi DESC"
    };

    OleDbDataReader reader = command.ExecuteReader();
    OleDbDataReader reader2 = command2.ExecuteReader();
    OleDbDataReader reader3 = command3.ExecuteReader();

    while (reader.Read())
    {
        cmb_kitaplık.Items.Add(reader[Localization.frmekle_ad]);
        //comboBox1.Items.Add(reader[Localization.frmekle_ad]);
    }
    while (reader2.Read())
    {
        //comboBox3.Items.Add(reader2[Localization.nasiyok]);
        //comboBox2.Items.Add(reader2[Localization.nasiyok]);
    }
    while (reader3.Read())
    {
        cmb_dil.Items.Add(reader3[Localization.frmekle_ad]);
    }

    string[] dizi = new string[cmb_dil.Items.Count];
    for (int i = 0; i < cmb_dil.Items.Count; i++)
    {
        dizi[i] = cmb_dil.Items[i].ToString();
    }

    cmb_dil.Items.Clear();

    for (int h = 0; h < dizi.Length; h++)
    {
        cmb_dil.Items.Add(dizi[h]);
    }
}*/
        /*void Kitaplik()
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
                cmb_kitaplık.Items.Add(reader[Localization.frmekle_ad]);
                //comboBox1.Items.Add(reader[Localization.frmekle_ad]);
            }

            baglan.Close();
        }
        void Dil()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command3 = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from dil Order By sayi DESC"
            };

            OleDbDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                cmb_dil.Items.Add(reader3[Localization.frmekle_ad]);
            }

            baglan.Close();
        }
        void Yapi()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command4 = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from yapi"
            };

            OleDbDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                cmb_kat.Items.Add(reader4[Localization.frmekle_ad]);
            }

            baglan.Close();
        }*/
        /*public void Griddoldur_kitap()
{
    con = new OleDbConnection(Localization.oledbcon);
    da = new OleDbDataAdapter("Select * from kitap", con);
    ds = new DataSet();
    con.Open();
    da.Fill(ds, "kitap");
    data_kitap.DataSource = ds.Tables["kitap"];
    con.Close();

    for (int i = 0; i < data_kitap.Rows.Count - 1; i++)
    {
        //cmb_kat.Items.Add(data_kitap.Rows[i].Cells[0].Value.ToString());
    }

    OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
    baglan.Open();
    OleDbCommand command2 = new OleDbCommand
    {
        Connection = baglan,
        CommandText = "select* from kitap"
    };

    OleDbDataReader reader2 = command2.ExecuteReader();

    while (reader2.Read())
    {
        //comboBox3.Items.Add(reader2[Localization.nasiyok]);
        //comboBox2.Items.Add(reader2[Localization.nasiyok]);
    }

    baglan.Close();
}*/
        /*foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
{
    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
}

dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);*/
        /*private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
{
    dt_dt1_void2();
    dataGridView1.ClearSelection();
    dataGridView2.ClearSelection();
}*/
        /*private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }*/
        /*try
           {
               MessageBox.Show("Test_try");

                       base.OnLoad(e);
           Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
           //lan oğlum iyi de bu zaten boş olmaya hep mahkum ki aq
           }
           catch (ArgumentNullException)
           {
               MessageBox.Show("Test_cath");

               //base.OnLoad(e);
               //Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
           }
           finally
           {
               MessageBox.Show("Test_finally");

               base.OnLoad(e);
               Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
           }*/
        /*bunlarda işe yaramadı, istediğim gibi değil hiç işimi görmedi çünkü kesinlikle yanlış kullandığım içindir
        Task.Run(() => btn_şıklat.PerformClick());
        metroProgressBar1.Visible = true;
        metroProgressBar1.Visible = false;*/
        /*sorun burada, diğer formdan kaynaklanan bir sorun değil bu çünkü baktım orada worker daima ama daima dolu olarak geliyor
        o gridde neden öyle bir sorun oluyor herhangi bir fikrim yok ama o griddoldurlar yüzünden öyle oluyor çünkü bir süre sonra datagrid patlıyor aq;griddolduru çıkarmamız lazım oradan, sorun tamamen o doldurmalardan kaynaklı
        evet şaka gibi ama baya baya datagrid'inde patladığını gördüm ve big red cross'lu ama içinde veri olan bir tuhaf stilde ve tıklandığında yanıt veren bir data grid geçmişti elime sfdhgfhgf
        bu kod o staj zamanı yaptığım kodun aynısıdır, herhangi bir ekleme çıkarmam olmamıştır, buraya yazmak istedim sadece, yoksa ondan daha işe yarar ve daha kısa bir şey buldum
        bu çok güzel ama task lı async wait'li bir şeyler yapmak lazım sanırım ya
        using (isleniyor frm = new isleniyor(guncelle))
        {
            frm.ShowDialog(this);
        }*/




        //ek sorular
        /*o sonda çıkmasına ne yapacağız ya
//bi de bunları alfabetik olarak sıralayalım mı ya, ya da en sık kullanılana göre; evet lan bu çok daha mantıklı oldu
//meğer sorun click olayında bunu yapmakmış, mouse enter kısmına alınınca sorun halloldu

//ama neden combobox kendisini kitliyor ki orada; oha comboboz ile alakası yomkmuş ki bunun, bu, metro modernin kendi kendisini kitlemesiymiş, başka formdan gelince böyle oluyor*/
        /*griddoldur2'de o verilere göre sıralanması lazım şimdi işte
ekleme bende de bunu nasıl yapacağız acaba?
e salak tahir, aq o zaman sayı veritabanından alsın verileri?çok pratik bir yol, ikisi için de ortak yol zaten orası aq
o sayıları ayrı bir comboboxa alsam orada sıralama yaptırsam sonra da o değerleri veritabanında arattırıp tek tek asıl comboboxımıza ekletsem
evet çalıştı ama hantal, güzel yanı şu ki hantallığı nasıl gidecek onu biliyorum o da benim yöntemle olur ancak; heye tahir senin yönteminle, sırf bir satır kodu unuttuğun için geldi bunlar başımıza aq dsgdfgf*/
        /*ekleme düzgün yansıyor silme doğru düzgün yansımıyor
        hayır ikisi de doğru yansımıyor forma
        xyz ya da kitaplık ile alakalı bir şey değil bu, genel bir sorun var; ama sorun yansıma sorunu aslında çünkü ana formda herhangi bir sorun yok ekleme silme konusunda şu an
        o zaman griddoldur lazım bize abi, en sağlıklısı o, o formda da öyle yapmışım zaten*/
        /*Kitaplik();
        cmb_kitaplık.Refresh();//oledb'nin kendisini refresh etmeye ihtiyacı var, eğer bu olursa belki o grid doldurlara da gerek kalmaz
        o zaman şöyle olacak, griddoldur yapıldıktan sonra refresh etme işlemini datagridden çekecek datareader'dan değil, evrim burada birikimli olarak birazcık hatalı ilerledi, datareader burada iş görecek bir yapı değil çünkü eski kalmış bir metot*/
        /*hiçbir insan eli bu kadar hassas değildir hatta yapayzeka bile olsa ve en köşedeki pixelde tıklamaya çalışsa bile sonuçta fare hareket etmiş
        olacağı için yine bu olay tetiklenecektir*/
        /*evet bak hakkatende tab index kaynaklı
        sen misin bunu bana yapan aq, aynı nesneden bir tane daha yaparım onu aktif ederim sonra üste gelince sen gelirsin geri ve kimsenin ruhu duymaz!!!!*/
        /*lan bu ds zaten ad olanı buluyor, burada ds'ler birbirine girmiş aq sorun bu kitap değil 
        kitaplık tablosuna girdiği için en son ds onu var zannediyor hala ds'de, onu düzeltirsek hallolur bu*/
        /*kökten iptal etmek değil istediğim şey ya, 
        o zaman şey yapcam
        sorted gelmesi daha iyi
        evet evet sorted gelmesi o üçgen sembolün orada gözükmesi iyi oldu*/
        /*lan ben bunları birbirine bağlayım? böyle olursa hem id'de gözükmez öyle gereksiz gereksiz
dataGridView1.Columns[6].DisplayIndex = 7;*/
        /*AAAA LAN MEĞERSE ARAMA YAPARKEN ONLAR BAŞA GELİYOR YA DAHA SONRA ONU İNDEX OLARAK ALIYOR HALİYLE
        E GİZLEYEMEM DE ONU ÇÜNKÜ BÜYÜTEBİLMELİLER ORAYI, O ZAMAN NASIL SİLECEKLER?
        ARKADA AYRI DATAGRİD OLACAK BİR TARAMA OLACAK O ZAMAN oradan alacak id'yi*/
        /*hmm bu aralara o iki değer gelecek; onlar da ilk ikisini oradan aldı
        ya da böyle yapmayalım; ama yok böyle yapmak zorundayız çünkü birisinde olmadığı zaman diğerini yerine yanlış olarak kaydedecek*/
        //E NEDEN KENDİNİ GÜNCELLEMEDİ? neden tetiklemiyorsun aq ya; şu an tetikledi o diğer formdan basınca; sanırım sonunda oldu
        //hata burada, buraya breakpoint koyalım; breakpoint koymayı öğrendim f9 ile oluyor f10 ile kod ilerliyor, o sayede boş olan değeri görebildim sonra da gerekeni yaptım ve artık çalışıyor
    }
}
