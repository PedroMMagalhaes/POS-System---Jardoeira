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
    public partial class frmPagar : MetroForm
    {
        public frmPagar(double valorTotal)
        {
            InitializeComponent();
            lblApagar.Text = Convert.ToString(valorTotal);
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            txtValorRecebido.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 2;
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 7;
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 9;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + 0;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtValorRecebido.Text = txtValorRecebido.Text + ".";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtValorRecebido.Text == "")
            {
                MessageBox.Show("Valor não inserido !!",
    "Erro Valores Inválidos", MessageBoxButtons.OK,
        MessageBoxIcon.Error);

            }
            else { 
            double troco;


            troco = Convert.ToDouble(txtValorRecebido.Text) - Convert.ToDouble(lblApagar.Text);

            lblTroco.Visible = true;
            btnPagar.Visible = true;
            lblTrocoFirst.Visible = true;
            lblTroco.Text = Convert.ToString(troco) + "€";
        }
        }




        private void metroButton2_Click(object sender, EventArgs e)
        {


            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            //SqlDataReader reader = null;
            Precos preco = new Precos();

            if (Convert.ToDouble(txtValorRecebido.Text) < Convert.ToDouble(lblApagar.Text))
            {
               
                MessageBox.Show("Valor recebido inferior ao total a pagar !!",
    "Erro Valores Inválidos", MessageBoxButtons.OK,
        MessageBoxIcon.Error);

                txtValorRecebido.Text = "";
                lblTroco.Text = "";
                lblTroco.Visible = false;
                btnPagar.Visible = false;

            }
            else
            {




                frmVenda frmVenda = (frmVenda)Application.OpenForms.Cast<Form>().Where(form => form.Name == "frmVenda").FirstOrDefault();
                if (frmVenda != null)
                {

                    try
                    {


                        SqlCommand cmd1 = new SqlCommand(
                        "INSERT INTO Pedidos output INSERTED.idPedido VALUES (@numeroMesa, @total)", conn);


                        cmd1.Parameters.AddWithValue("@numeroMesa", "0");
                        cmd1.Parameters.AddWithValue("@total", Convert.ToDouble(lblApagar.Text));


                        try
                        {
                            conn.Open();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Conexao BD", MessageBoxButtons.OK);

                        }

                        //id pedido »»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»
                        int idPedido = (int)cmd1.ExecuteScalar();
                        preco.idPedido = idPedido;

                        //MessageBox.Show(idPedido.ToString(), "Conexao BD", MessageBoxButtons.OK);




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Conexao BD", MessageBoxButtons.OK);
                    }

                    //add cada item para a tabela
                    foreach (ListViewItem item in frmVenda.getListProduto().Items)
                    {
                        try
                        {

                            if (!(conn.State == System.Data.ConnectionState.Open))
                            {
                                conn.Open();
                            }

                            SqlCommand cmd = new SqlCommand(
                         "SELECT idProduto From Produtos Where nome=@nomeProduto;", conn);

                            cmd.Parameters.AddWithValue("@nomeProduto", item.Name.ToString());



                            //reading value to obtain result
                            int idProduto = (int)cmd.ExecuteScalar();
                            //MessageBox.Show(idProduto.ToString(), "INfo", MessageBoxButtons.OK);


                            SqlCommand cmd2 = new SqlCommand(
                           "INSERT INTO PedidosProdutos VALUES(@idPedido, @idProduto, @quantidade); ", conn);

                            cmd2.Parameters.AddWithValue("@idPedido", preco.idPedido);
                            cmd2.Parameters.AddWithValue("@idProduto", idProduto);
                            cmd2.Parameters.AddWithValue("@quantidade", Convert.ToInt32(item.SubItems[1].Text));

                            cmd2.ExecuteNonQuery();



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                        }
                        finally
                        {


                            if (conn.State == System.Data.ConnectionState.Open)
                            {
                                conn.Close();
                                //conn.Dispose();
                                //conn = null;
                            }

                           


                        }

                    }
                }


                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }   //Clear texts and labels

                lblApagar.Text = String.Empty;
                lblTroco.Text = String.Empty;
                txtValorRecebido.Text = String.Empty;
                lblTrocoFirst.Visible = false;
                btnPagar.Visible = false;

                this.Visible = false;

                frmVenda.listProdutos.Items.Clear();
                frmVenda.lblTotal.Text = "000";
                MessageBox.Show("Venda Registada !!",
                 "Informação de Venda", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }

        }

    }

}





           


              
            
