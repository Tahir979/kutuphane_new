using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class frmkütüphanedüzeni : MetroFramework.Forms.MetroForm
    {
        public frmkütüphanedüzeni()
        {
            InitializeComponent();
        }

        private void frmkütüphanedüzeni_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            katlar x = new katlar();
            x.Show();
        }
    }
}
