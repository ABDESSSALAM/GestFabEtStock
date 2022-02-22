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
    public partial class Nv_Fab : Form
    {
        public Nv_Fab()
        {
            InitializeComponent();
        }
        GestionDB GB = new GestionDB();
        private void Nv_Fab_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.ListFab();

            comboBox1.DisplayMember = "NomArticle";
            comboBox1.ValueMember = "CodeArticle";
            comboBox1.DataSource = GB.codeArt();

            comboBox2.DisplayMember = "NomDepot";
            comboBox2.ValueMember = "CodeDepot";
            comboBox2.DataSource = GB.codeDepot();

            comboBox3.DisplayMember = "NumOrder";
            comboBox3.ValueMember = "NumOrder";
            comboBox3.DataSource = GB.ComboNumOrd();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
                string codeA = comboBox1.SelectedValue.ToString();
                string codeD = comboBox2.SelectedValue.ToString();
                int NumO = int.Parse(comboBox3.SelectedValue.ToString());
                int Q = int.Parse(textBox1.Text);
                if(GB.ajouterFab(NumO, codeA, codeD, Q))
                {
                    MessageBox.Show("ajouter");
                 dataGridView1.DataSource = GB.ListFab();
                 }
        }
    }
}
