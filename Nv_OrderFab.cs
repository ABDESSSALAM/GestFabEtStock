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
    public partial class Nv_OrderFab : Form
    {
        public Nv_OrderFab()
        {
            InitializeComponent();
        }
        GestionDB GB = new GestionDB();
        private void Nv_OrderFab_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.ListOrderFab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GB.ajouterOrderFab(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())))
            {
                MessageBox.Show("ajouter");
                dataGridView1.DataSource = GB.ListOrderFab();
            }
        }
    }
}
