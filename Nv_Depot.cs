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
    public partial class Nv_Depot : Form
    {
        public Nv_Depot()
        {
            InitializeComponent();
        }
        GestionDB GB = new GestionDB();
        private void Nv_Depot_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.listDepot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GB.AjouterDept(textBox2.Text))
            {
                MessageBox.Show("ajouter");
                dataGridView1.DataSource = GB.listDepot();
            }
        }
    }
}
