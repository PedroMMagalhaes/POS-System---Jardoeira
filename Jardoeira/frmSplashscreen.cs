using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jardoeira
{
    public partial class frmSplashscreen : MetroForm
    {
        public frmSplashscreen()
        {
            InitializeComponent();
           
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSplashscreen_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();

            //set time interval 3 sec

            timer1.Interval = 3000;

            //starts the timer

            timer1.Start();

            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            timer1.Stop();

            //display mainform

            this.Hide();
            var form2 = new frmLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
