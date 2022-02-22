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
    public partial class ListFab : Form
    {
        public ListFab()
        {
            InitializeComponent();
        }

        private void ListFab_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPricipal mp = new MenuPricipal();
            mp.Show();
        }
        GestionDB GB = new GestionDB();
        private void ListFab_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.ListFab();
            comboBox4.DisplayMember = "NomArticle";
            comboBox4.ValueMember = "CodeArticle";
            comboBox4.DataSource = GB.codeArt();

            comboBox5.DisplayMember = "NomDepot";
            comboBox5.ValueMember = "CodeDepot";
            comboBox5.DataSource = GB.codeDepot();

            comboBox1.DisplayMember = "NumOrder";
            comboBox1.ValueMember = "NumOrder";
            comboBox1.DataSource = GB.ComboNumOrd();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeA = comboBox4.SelectedValue.ToString();
            string codeD = comboBox5.SelectedValue.ToString();
            int NumO = int.Parse(comboBox1.SelectedValue.ToString());
            int Q = int.Parse(textBox1.Text);
           if(GB.modifierFab(NumO, codeA, codeD, Q)){
                MessageBox.Show("modifier");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox4.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox5.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
