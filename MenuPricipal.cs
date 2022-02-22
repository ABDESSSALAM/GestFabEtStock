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
    public partial class MenuPricipal : Form
    {
        public MenuPricipal()
        {
            InitializeComponent();
        }
        
        private void MenuPricipal_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ds=null;
            if (radioButton1.Checked == true)
            {
                ds = new Sisaire();
                
            }
            if (radioButton3.Checked)
            {
                groupBox1.Visible = true;
                if (rad1.Checked)
                {
                    ds = new ListerStocks();
                }
                if (rad2.Checked)
                {
                    ds = new NomArticleNomDepot();
                }
                if (rad3.Checked)
                {
                    ds = new QteSup50();
                }
                if (rad4.Checked)
                {
                    ds = new ListFab();
                }
            }
            if (ds != null)
            {
                ds.Show();
                this.Hide();
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible= !groupBox1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GestionDB gd = new GestionDB();
                if (gd.testCn())
                {
                    MessageBox.Show("okk!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void MenuPricipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
