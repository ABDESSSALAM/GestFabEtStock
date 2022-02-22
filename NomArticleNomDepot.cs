using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM01
{
    public partial class NomArticleNomDepot : Form
    {
        public NomArticleNomDepot()
        {
            InitializeComponent();
        }

        private void NomArticleNomDepot_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPricipal mp = new MenuPricipal();
            mp.Show();
        }
        GestionDB GB = new GestionDB();
        private void NomArticleNomDepot_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.listNomArticleEtDepo();
        }
    }
}
