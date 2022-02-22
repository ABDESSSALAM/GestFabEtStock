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
    public partial class ListerStocks : Form
    {
        public ListerStocks()
        {
            InitializeComponent();
        }

        private void ListerStocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPricipal mp = new MenuPricipal();
            mp.Show();
        }
        GestionDB GB = new GestionDB();
        private void ListerStocks_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "NomDepot";
            comboBox1.ValueMember = "CodeDepot";
            comboBox1.DataSource = GB.codeDepot();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //string CodeD = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = GB.ListArticle("Dep1");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
