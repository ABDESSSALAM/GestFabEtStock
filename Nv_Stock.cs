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
    public partial class Nv_Stock : Form
    {
        public Nv_Stock()
        {
            InitializeComponent();
        }
        GestionDB GB = new GestionDB();
        private void Nv_Stock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.ListStock();
            comboBox1.DataSource = GB.codeArt();
            comboBox1.DisplayMember = "NomArticle";
            comboBox1.ValueMember = "CodeArticle";
            comboBox2.DataSource = GB.codeDepot();
            comboBox2.DisplayMember = "NomDepot";
            comboBox2.ValueMember = "CodeDepot";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codeA = comboBox1.SelectedValue.ToString();
            string codeD = comboBox2.SelectedValue.ToString();
            if (GB.ajouterStock(codeA, codeD, int.Parse(textBox1.Text))){
                MessageBox.Show("ajouter");
                dataGridView1.DataSource = GB.ListStock();
            }

        }
    }
}
