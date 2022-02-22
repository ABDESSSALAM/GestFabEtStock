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
    public partial class Nv_Article : Form
    {
        public Nv_Article()
        {
            InitializeComponent();
        }
        GestionDB GB = new GestionDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GB.ListArticle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GB.ajouterArticle(textBox2.Text))
            {
                MessageBox.Show("Article a ete ajouter");
            }
            dataGridView1.DataSource = GB.ListArticle();
        }
    }
}
