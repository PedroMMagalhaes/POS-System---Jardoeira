using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Jardoeira
{
    public partial class frmVenda : MetroForm
    {
        public double valorTotal { get; set; }
        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {


            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Pão"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Pão"))
                    {

                    double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                    item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoPao();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoPao();

                        lblTotal.Text = total.ToString();
                    } 
            }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Pão";
                lvi1.Text = "Pão";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoPao().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoPao();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus() ;
        }

        private void btnRefrigerantes_Click(object sender, EventArgs e)
        {



            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Refrigerante"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Refrigerante"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoRefrigerante();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoRefrigerante();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Refrigerante";
                lvi1.Text = "Refrigerante";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoRefrigerante().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoRefrigerante();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            valorTotal = Convert.ToDouble(lblTotal.Text);

            
            frmPagar f2 = new frmPagar(valorTotal);
            f2.ShowDialog(); // Shows Form
        }

        private void btnAzeitonas_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Azeitonas"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Azeitonas"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoAzeitonas();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoAzeitonas();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Azeitonas";
                lvi1.Text = "Azeitonas";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoAzeitonas().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoAzeitonas();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnMoelas_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Moelas"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Moelas"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetPrecoMoelas();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetPrecoMoelas();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Moelas";
                lvi1.Text = "Moelas";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetPrecoMoelas().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetPrecoMoelas();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnMorcela_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Morcela"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Morcela"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoMorcela();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoMorcela();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Morcela";
                lvi1.Text = "Morcela";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoMorcela().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoMorcela();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnSopa_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Sopa"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Sopa"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoSopadoDia();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoSopadoDia();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Sopa";
                lvi1.Text = "Sopa";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoSopadoDia().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoSopadoDia();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Frango Inteiro"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Frango Inteiro"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoFrango();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoFrango();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Frango Inteiro";
                lvi1.Text = "Frango Inteiro";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoFrango().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoFrango();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnFrangoMeio_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Meio Frango"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Meio Frango"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoMeioFrango();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoMeioFrango();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Meio Frango";
                lvi1.Text = "Meio Frango";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoMeioFrango().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoMeioFrango();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnEntrecosto_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Entrecosto Inteiro"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Entrecosto Inteiro"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoEntrecosto();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoEntrecosto();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Entrecosto Inteiro";
                lvi1.Text = "Entrecosto Inteiro";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoEntrecosto().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoEntrecosto();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnMeioEntrecosto_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Meio Entrecosto"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Meio Entrecosto"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoMeioEntrecosto();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoMeioEntrecosto();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Meio Entrecosto";
                lvi1.Text = "Meio Entrecosto";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoMeioEntrecosto().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoMeioEntrecosto();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void btnBacalhau_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Bacalhau"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Bacalhau"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoBacalhau();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoBacalhau();
                        
                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Bacalhau";
                lvi1.Text = "Bacalhau";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoBacalhau().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoBacalhau();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Sobremesa Diversas"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Sobremesa Diversas"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoSobremesa();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoSobremesa();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Sobremesa Diversas";
                lvi1.Text = "Sobremesa Diversas";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoSobremesa().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoSobremesa();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Fruta"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Fruta"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoFruta();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoFruta();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Fruta";
                lvi1.Text = "Fruta";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoFruta().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoFruta();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Água"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Água"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoAgua();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoAgua();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Água";
                lvi1.Text = "Água";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoAgua().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoAgua();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Imperial"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Imperial"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoImperial();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoImperial();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Imperial";
                lvi1.Text = "Imperial";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoImperial().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoImperial();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Ala dos Namorados"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Ala dos Namorados"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoAladosNamorados();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoAladosNamorados();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Ala dos Namorados";
                lvi1.Text = "Ala dos Namorados";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoAladosNamorados().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoAladosNamorados();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Vinho 1L"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Vinho 1L"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoVinho1();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoVinho1();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Vinho 1L";
                lvi1.Text = "Vinho 1L";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoVinho1().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoVinho1();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Vinho 0.5L"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Vinho 0.5L"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoVinhoMeio();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoVinhoMeio();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Vinho 0.5L";
                lvi1.Text = "Vinho 0.5L";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoVinhoMeio().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoVinhoMeio();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Sangria 1L"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Sangria 1L"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoSangriaLitro();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoSangriaLitro();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Sangria 1L";
                lvi1.Text = "Sangria 1L";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoSangriaLitro().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoSangriaLitro();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Sangria Copo"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Sangria Copo"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoSangriaCopo();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoSangriaCopo();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Sangria Copo";
                lvi1.Text = "Sangria Copo";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoSangriaCopo().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoSangriaCopo();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Vinho Copo"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Vinho Copo"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetPrecoVinhoCopo();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetPrecoVinhoCopo();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Vinho Copo";
                lvi1.Text = "Vinho Copo";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetPrecoVinhoCopo().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetPrecoVinhoCopo();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Café"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Café"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoCafe();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoCafe();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Café";
                lvi1.Text = "Café";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoCafe().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoCafe();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {

            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Filhós"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Filhós"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetprecoFilhos();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetprecoFilhos();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Filhós";
                lvi1.Text = "Filhós";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetprecoFilhos().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetprecoFilhos();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Fatia de Bolo"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Fatia de Bolo"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetPrecoFatiaBolo();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetPrecoFatiaBolo();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Fatia de Bolo";
                lvi1.Text = "Fatia de Bolo";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetPrecoFatiaBolo().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetPrecoFatiaBolo();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            Precos preco = new Precos();

            if (listProdutos.Items.ContainsKey("Chá"))
            {

                foreach (ListViewItem item in listProdutos.Items)
                {
                    if (item.Name.Contains("Chá"))
                    {

                        double value = Convert.ToDouble(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = value.ToString();

                        String lastChar;
                        lastChar = item.SubItems[2].Text;
                        lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);
                        double value2 = Convert.ToDouble(lastChar) + preco.GetPrecoCha();
                        item.SubItems[2].Text = value2.ToString() + "‎€";


                        String teste;
                        teste = lblTotal.Text;
                        teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                        double total = Convert.ToDouble(teste) + preco.GetPrecoCha();

                        lblTotal.Text = total.ToString();
                    }
                }
                // »»»»»»»» TO DO 
                // Retirar stock do produto
                //  Adicionar uma order
                //total preco

            }
            else

            {

                ListViewItem lvi1 = new ListViewItem();

                lvi1.Font = new Font(listProdutos.Font, FontStyle.Bold);
                lvi1.Name = "Chá";
                lvi1.Text = "Chá";
                lvi1.SubItems.Add("1");
                lvi1.SubItems.Add(preco.GetPrecoCha().ToString() + "‎€");
                listProdutos.Items.Add(lvi1);

                String teste;
                teste = lblTotal.Text;
                teste = Convert.ToString(teste).Replace("‎€", String.Empty);
                double total = Convert.ToDouble(teste) + preco.GetPrecoCha();

                lblTotal.Text = total.ToString();
            }

            listProdutos.Focus();
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            double valorRetirar;
            foreach (ListViewItem eachItem in listProdutos.SelectedItems)
            {

                
                Precos preco = new Precos();
                
                if (eachItem.Name.Contains("Café"))
                {
                  valorRetirar = preco.GetprecoCafe();
                }else if (eachItem.Name.Contains("Pão"))
                {
                    valorRetirar = preco.GetprecoPao();
                }
                else if (eachItem.Name.Contains("Azeitonas"))
                {
                    valorRetirar = preco.GetprecoAzeitonas();
                }
                else if (eachItem.Name.Contains("Moelas"))
                {
                    valorRetirar = preco.GetPrecoMoelas();
                }
                else if (eachItem.Name.Contains("Morcela"))
                {
                    valorRetirar = preco.GetprecoMorcela();
                }
                else if (eachItem.Name.Contains("Sopa"))
                {
                    valorRetirar = preco.GetprecoSopadoDia();
                }
                else if (eachItem.Name.Contains("Frango Inteiro"))
                {
                    valorRetirar = preco.GetprecoFrango();
                }
                else if (eachItem.Name.Contains("Meio Frango"))
                {
                    valorRetirar = preco.GetprecoMeioFrango();
                }
                else if (eachItem.Name.Contains("Entrecosto Inteiro"))
                {
                    valorRetirar = preco.GetprecoEntrecosto();
                }
                else if (eachItem.Name.Contains("Meio Entrecosto"))
                {
                    valorRetirar = preco.GetprecoMeioEntrecosto();
                }
                else if (eachItem.Name.Contains("Bacalhau"))
                {
                    valorRetirar = preco.GetprecoBacalhau();
                }
                else if (eachItem.Name.Contains("Sobremesa"))
                {
                    valorRetirar = preco.GetprecoSobremesa();
                }
                else if (eachItem.Name.Contains("Fruta"))
                {
                    valorRetirar = preco.GetprecoFruta();
                }
                else if (eachItem.Name.Contains("Água"))
                {
                    valorRetirar = preco.GetprecoAgua();
                }
                else if (eachItem.Name.Contains("Refrigerante"))
                {
                    valorRetirar = preco.GetprecoRefrigerante();
                }
                else if (eachItem.Name.Contains("Imperial"))
                {
                    valorRetirar = preco.GetprecoImperial();
                }
                else if (eachItem.Name.Contains("Ala dos Namorados"))
                {
                    valorRetirar = preco.GetprecoAladosNamorados();
                }
                else if (eachItem.Name.Contains("Vinho 1L"))
                {
                    valorRetirar = preco.GetprecoVinho1();
                }
                else if (eachItem.Name.Contains("Vinho 0.5L"))
                {
                    valorRetirar = preco.GetprecoVinhoMeio();
                }
                else if (eachItem.Name.Contains("Sangria"))
                {
                    valorRetirar = preco.GetprecoSangriaLitro();
                }
                else if (eachItem.Name.Contains("Sangria Copo"))
                {
                    valorRetirar = preco.GetprecoSangriaCopo();
                }
                else if (eachItem.Name.Contains("Vinho Copo"))
                {
                    valorRetirar = preco.GetPrecoVinhoCopo();
                }
                else if (eachItem.Name.Contains("Café"))
                {
                    valorRetirar = preco.GetprecoCafe();
                }
                else if (eachItem.Name.Contains("Filhós"))
                {
                    valorRetirar = preco.GetprecoFilhos();
                }
                else if (eachItem.Name.Contains("Fatia Bolo"))
                {
                    valorRetirar = preco.GetPrecoFatiaBolo();
                }
                else if (eachItem.Name.Contains("Chá"))
                {
                    valorRetirar = preco.GetPrecoCha();
                }else
                {
                    valorRetirar = 0;
                }

                String lastChar;
                lastChar = eachItem.SubItems[2].Text;
                lastChar = Convert.ToString(lastChar).Replace("‎€", String.Empty);

                int teste = Convert.ToInt32(eachItem.SubItems[1].Text);

                double valorAtual = Convert.ToDouble(lastChar);

                double valorFinal = valorAtual - valorRetirar;

                double valorTeste = Convert.ToDouble(lblTotal.Text);
                double valorTeste2 = valorTeste - valorRetirar;

                lblTotal.Text = valorTeste2.ToString();

                if (teste > 1)
                {
                    teste = teste - 1;
                    eachItem.SubItems[1].Text = Convert.ToString(teste);
                    eachItem.SubItems[2].Text = Convert.ToString(valorFinal) + "‎€";
                    
                    // listProdutos.Items.Remove(eachItem);
                    teste = 0;
            } else
                {
                    listProdutos.Items.Remove(eachItem);
                }
    }
}

        private void frmVenda_Load(object sender, EventArgs e)
        {
            listProdutos.Focus();
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public ListView getListProduto()
        {
            return listProdutos;
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












