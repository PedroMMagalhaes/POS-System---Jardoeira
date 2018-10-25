using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace Jardoeira
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();

           

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda f2 = new frmVenda();
            f2.ShowDialog(); // Shows Form
            this.Close();
        }

        private void btnUtilizadores_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new frmUtilizadores();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

           // frmUtilizadores f2 = new frmUtilizadores();
            //f2.ShowDialog(); // Shows Form
            //this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            this.Hide();
            var form2 = new frmVenda();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

            //frmVenda f2 = new frmVenda();
            //f2.ShowDialog(); // Shows Form
            
           // this.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            this.Hide();
            var form2 = new frmProdutos();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

            //frmProdutos f2 = new frmProdutos();
           // f2.ShowDialog(); // Shows Form
           // this.Visible = false;
        }

        private void Menu_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new frmEstatisticas();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            // frmEstatisticas f2 = new frmEstatisticas();
            //f2.ShowDialog(); // Shows Form
            //this.Visible = false;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
