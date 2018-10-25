using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Jardoeira
{
    public partial class frmLogin : MetroForm 
    {
        public String hash;
        public String hash1;
        public frmLogin()
        {
            InitializeComponent();
          


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            //SqlDataReader reader = null;

            // String message = "A conectar ...";
            String caption = "Informação de Conexão";
            MessageBoxButtons buttons = MessageBoxButtons.OK;


            //OpenConnection - Error Message included
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, caption, buttons);
            }


            //Verify User and Password

            try
            {

                SqlCommand cmd = new SqlCommand(
                "Select password from Utilizadores where utilizador = @utilizador", conn);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@utilizador";
                param.Value = txtUtilizador.Text;

                //add param ...
                cmd.Parameters.Add(param);

                //reading value to obtain result
                String password = (String)cmd.ExecuteScalar();


                hash = password;
                

                byte[] data1 = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
                data1 = new System.Security.Cryptography.SHA256Managed().ComputeHash(data1);
                hash1 = System.Text.Encoding.ASCII.GetString(data1);

                
                    
                // Show results - debug
                //MessageBox.Show(password, caption, buttons);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, caption, buttons);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;

                if (hash == hash1)
                {
                    MessageBox.Show("Login Efetuado com Sucesso !!",
    "Login com Sucesso", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                    //Menu f2 = new Jardoeira.Menu();

                    this.Hide();
                    var form2 = new Menu();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                    //f2.ShowDialog(); // Shows Form
                    hash = "";
                    hash1 = "";
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Palavra Passe Errada !!",
    "Erro Password", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                    txtPassword.Text = "";
                }
            }

        } //passar forms
          // frmSplashscreen f2 = new frmSplashscreen();
        //f2.ShowDialog(); // Shows Form

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUtilizador.Focus();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

