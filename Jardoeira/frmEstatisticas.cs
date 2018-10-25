using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardoeira
{
    public partial class frmEstatisticas : MetroForm
    {
        public frmEstatisticas()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            try
            {

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Conexao BD", MessageBoxButtons.OK);

                }



                string sql = "Select * from pedidos p1, PedidosProdutos p3, Produtos p2 where p3.idProduto = p2.idProduto and p1.idPedido = p3.idPedido; ";

                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();

                dataadapter.Fill(ds, "Relatorio");

                teste.DataSource = ds;
                teste.DataMember = "Relatorio";


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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            try
            {

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Conexao BD", MessageBoxButtons.OK);

                }



                string sql = "Select * From Produtos";

                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();

                dataadapter.Fill(ds, "Relatorio");

                teste.DataSource = ds;
                teste.DataMember = "Relatorio";


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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(teste, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }


        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
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
