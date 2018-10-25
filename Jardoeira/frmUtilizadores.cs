using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Jardoeira
{
    public partial class frmUtilizadores : MetroForm
    {
        public frmUtilizadores()
        {
            InitializeComponent();
           
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtPassword.Text = "";
            txtUtilizador.Text = "";
            txtSeccao.Text = "";
            cmbTipoUtilizador.SelectedItem = "Vendedor";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            //SqlDataReader reader = null;

            // String message = "A conectar ...";
            String caption = "Informação de Conexão";
            MessageBoxButtons buttons = MessageBoxButtons.OK;


            //Encrypt Password

            byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);


            //OpenConnection - Error Message included
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, caption, buttons);

            }


            // Show results - debug
            //MessageBox.Show("Teste", caption, buttons);

            //Verify User and Password

            try
            {

                int valorUtilizador = 0;

                if (cmbTipoUtilizador.SelectedText == "Vendedor")
                {

                    valorUtilizador = 1;

                }
                else if (cmbTipoUtilizador.SelectedText == "Administrador")
                {
                    valorUtilizador = 0;
                  
                }


                SqlCommand cmd = new SqlCommand(
                "Insert INTO [Utilizadores] ([nome], [utilizador], [password], [seccao], [tipoUtilizador]) VALUES (@nome, @utilizador, @password, @seccao, @tipoUtilizador)", conn);


                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@utilizador", txtUtilizador.Text);
                cmd.Parameters.AddWithValue("@password", hash);
                cmd.Parameters.AddWithValue("@seccao", txtSeccao.Text);
                cmd.Parameters.AddWithValue("@tipoUtilizador", valorUtilizador);



                if (cmbTipoUtilizador.SelectedText == "Vendedor")
                {

                    cmd.Parameters.AddWithValue("[@tipoUtilizador]", '1');

                }
                else if (cmbTipoUtilizador.SelectedText == "Administrador")
                {
                    cmd.Parameters.AddWithValue("[@tipoUtilizador]", '0');
                }
               


                //add param ...
                

                //reading value to obtain result
                cmd.ExecuteNonQuery();

                // Show results - debug
                //MessageBox.Show(cmd.ToString(), caption, buttons);


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

                txtNome.Text = "";
                txtPassword.Text = "";
                txtUtilizador.Text = "";
                txtSeccao.Text = "";
                cmbTipoUtilizador.SelectedItem = "Vendedor";
            }

        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
    }

