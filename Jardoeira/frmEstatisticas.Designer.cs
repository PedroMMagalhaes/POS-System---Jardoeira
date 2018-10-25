namespace Jardoeira
{
    partial class frmEstatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedidos = new MetroFramework.Controls.MetroButton();
            this.teste = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton16 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.teste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(1148, 75);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(149, 51);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "Verificar Pedidos Registados";
            this.btnPedidos.UseSelectable = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // teste
            // 
            this.teste.AllowUserToAddRows = false;
            this.teste.AllowUserToDeleteRows = false;
            this.teste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teste.Location = new System.Drawing.Point(144, 63);
            this.teste.Name = "teste";
            this.teste.ReadOnly = true;
            this.teste.Size = new System.Drawing.Size(954, 565);
            this.teste.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1148, 168);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(149, 51);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Verificar Produtos Inseridos";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(1148, 575);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(149, 51);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Exportar Dados - Excel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton16
            // 
            this.metroButton16.BackgroundImage = global::Jardoeira.Properties.Resources.back_icon;
            this.metroButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton16.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton16.Location = new System.Drawing.Point(16, 550);
            this.metroButton16.Name = "metroButton16";
            this.metroButton16.Size = new System.Drawing.Size(99, 76);
            this.metroButton16.TabIndex = 13;
            this.metroButton16.UseSelectable = true;
            this.metroButton16.Click += new System.EventHandler(this.metroButton16_Click);
            // 
            // frmEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 669);
            this.Controls.Add(this.metroButton16);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.btnPedidos);
            this.Name = "frmEstatisticas";
            this.Text = "Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.teste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnPedidos;
        private System.Windows.Forms.DataGridView teste;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton16;
    }
}