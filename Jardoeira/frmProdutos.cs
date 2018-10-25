using MetroFramework.Forms;
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

namespace Jardoeira
{
    public partial class frmProdutos : MetroForm
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
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


            // Show results - debug
            //MessageBox.Show("Teste", caption, buttons);

            //Verify User and Password

            try
            {

           


                SqlCommand cmd = new SqlCommand(
                "Insert INTO [Produtos] ([nome], [descricao], [preco], [quantidadeStock]) VALUES (@nome, @descricao, @preco, @quantidadeStock)", conn);


                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                cmd.Parameters.AddWithValue("@quantidadeStock", txtQuantidade.Text);
  

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
                txtDescricao.Text = "";
                txtPreco.Text = "";
                txtQuantidade.Text = "";
               
            }


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
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
