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
    public partial class Sisaire : Form
    {
        public Sisaire()
        {
            InitializeComponent();
        }

        private void aricleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            Nv_Article NA = new Nv_Article();
            NA.MdiParent = this;
            
            NA.Show();
            NA.Top = 0;
            NA.Left = 0;


        }

        private void depotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Nv_Depot ND = new Nv_Depot();
            ND.MdiParent = this;
            
            ND.Show();
            ND.Left = 0;
            ND.Top = 0;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Nv_Stock NS = new Nv_Stock();
            NS.MdiParent = this;
            NS.Show();
            NS.Top = 0;
            NS.Left = 0;
        }

        private void fabriquatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Nv_Fab NF = new Nv_Fab();
            NF.MdiParent = this;
            NF.Show();
            NF.Left = 0;
            NF.Top = 0;
        }

        private void Sisaire_Load(object sender, EventArgs e)
        {

        }

        private void Sisaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPricipal mp = new MenuPricipal();
            mp.Show();
        }
    }
}
