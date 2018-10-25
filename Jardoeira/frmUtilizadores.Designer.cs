namespace Jardoeira
{
    partial class frmUtilizadores
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabAdicionar = new MetroFramework.Controls.MetroTabPage();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.cmbTipoUtilizador = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSeccao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUtilizador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.tabEditar = new MetroFramework.Controls.MetroTabPage();
            this.cmbTipoUtilizadorEditar = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSeccaoEditar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeUtilizadorEditar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordEditar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeEditar = new MetroFramework.Controls.MetroTextBox();
            this.metroButton16 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabAdicionar.SuspendLayout();
            this.tabEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabAdicionar);
            this.metroTabControl1.Controls.Add(this.tabEditar);
            this.metroTabControl1.Location = new System.Drawing.Point(13, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(946, 453);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabAdicionar
            // 
            this.tabAdicionar.Controls.Add(this.metroButton16);
            this.tabAdicionar.Controls.Add(this.btnLimpar);
            this.tabAdicionar.Controls.Add(this.btnGuardar);
            this.tabAdicionar.Controls.Add(this.cmbTipoUtilizador);
            this.tabAdicionar.Controls.Add(this.metroLabel5);
            this.tabAdicionar.Controls.Add(this.metroLabel4);
            this.tabAdicionar.Controls.Add(this.txtSeccao);
            this.tabAdicionar.Controls.Add(this.metroLabel3);
            this.tabAdicionar.Controls.Add(this.txtUtilizador);
            this.tabAdicionar.Controls.Add(this.metroLabel2);
            this.tabAdicionar.Controls.Add(this.txtPassword);
            this.tabAdicionar.Controls.Add(this.metroLabel1);
            this.tabAdicionar.Controls.Add(this.txtNome);
            this.tabAdicionar.HorizontalScrollbarBarColor = true;
            this.tabAdicionar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdicionar.HorizontalScrollbarSize = 10;
            this.tabAdicionar.Location = new System.Drawing.Point(4, 38);
            this.tabAdicionar.Name = "tabAdicionar";
            this.tabAdicionar.Size = new System.Drawing.Size(938, 411);
            this.tabAdicionar.TabIndex = 0;
            this.tabAdicionar.Text = "Adicionar";
            this.tabAdicionar.VerticalScrollbarBarColor = true;
            this.tabAdicionar.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdicionar.VerticalScrollbarSize = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(293, 283);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(32, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbTipoUtilizador
            // 
            this.cmbTipoUtilizador.FormattingEnabled = true;
            this.cmbTipoUtilizador.ItemHeight = 23;
            this.cmbTipoUtilizador.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cmbTipoUtilizador.Location = new System.Drawing.Point(553, 76);
            this.cmbTipoUtilizador.Name = "cmbTipoUtilizador";
            this.cmbTipoUtilizador.Size = new System.Drawing.Size(166, 29);
            this.cmbTipoUtilizador.TabIndex = 11;
            this.cmbTipoUtilizador.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(553, 44);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Tipo de Utilizador :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(293, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Secção :";
            // 
            // txtSeccao
            // 
            // 
            // 
            // 
            this.txtSeccao.CustomButton.Image = null;
            this.txtSeccao.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtSeccao.CustomButton.Name = "";
            this.txtSeccao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeccao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeccao.CustomButton.TabIndex = 1;
            this.txtSeccao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeccao.CustomButton.UseSelectable = true;
            this.txtSeccao.CustomButton.Visible = false;
            this.txtSeccao.Lines = new string[0];
            this.txtSeccao.Location = new System.Drawing.Point(293, 161);
            this.txtSeccao.MaxLength = 32767;
            this.txtSeccao.Name = "txtSeccao";
            this.txtSeccao.PasswordChar = '\0';
            this.txtSeccao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeccao.SelectedText = "";
            this.txtSeccao.SelectionLength = 0;
            this.txtSeccao.SelectionStart = 0;
            this.txtSeccao.ShortcutsEnabled = true;
            this.txtSeccao.Size = new System.Drawing.Size(166, 23);
            this.txtSeccao.TabIndex = 8;
            this.txtSeccao.UseSelectable = true;
            this.txtSeccao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeccao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(293, 44);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Nome de Utilizador :";
            // 
            // txtUtilizador
            // 
            // 
            // 
            // 
            this.txtUtilizador.CustomButton.Image = null;
            this.txtUtilizador.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtUtilizador.CustomButton.Name = "";
            this.txtUtilizador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUtilizador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUtilizador.CustomButton.TabIndex = 1;
            this.txtUtilizador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUtilizador.CustomButton.UseSelectable = true;
            this.txtUtilizador.CustomButton.Visible = false;
            this.txtUtilizador.Lines = new string[0];
            this.txtUtilizador.Location = new System.Drawing.Point(293, 76);
            this.txtUtilizador.MaxLength = 32767;
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.PasswordChar = '\0';
            this.txtUtilizador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUtilizador.SelectedText = "";
            this.txtUtilizador.SelectionLength = 0;
            this.txtUtilizador.SelectionStart = 0;
            this.txtUtilizador.ShortcutsEnabled = true;
            this.txtUtilizador.Size = new System.Drawing.Size(166, 23);
            this.txtUtilizador.TabIndex = 6;
            this.txtUtilizador.UseSelectable = true;
            this.txtUtilizador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUtilizador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password :";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(32, 161);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(166, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nome Completo :";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(32, 76);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(166, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabEditar
            // 
            this.tabEditar.Controls.Add(this.cmbTipoUtilizadorEditar);
            this.tabEditar.Controls.Add(this.metroLabel6);
            this.tabEditar.Controls.Add(this.metroLabel7);
            this.tabEditar.Controls.Add(this.txtSeccaoEditar);
            this.tabEditar.Controls.Add(this.metroLabel8);
            this.tabEditar.Controls.Add(this.txtNomeUtilizadorEditar);
            this.tabEditar.Controls.Add(this.metroLabel9);
            this.tabEditar.Controls.Add(this.txtPasswordEditar);
            this.tabEditar.Controls.Add(this.metroLabel10);
            this.tabEditar.Controls.Add(this.txtNomeEditar);
            this.tabEditar.HorizontalScrollbarBarColor = true;
            this.tabEditar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEditar.HorizontalScrollbarSize = 10;
            this.tabEditar.Location = new System.Drawing.Point(4, 38);
            this.tabEditar.Name = "tabEditar";
            this.tabEditar.Size = new System.Drawing.Size(938, 411);
            this.tabEditar.TabIndex = 1;
            this.tabEditar.Text = "Editar";
            this.tabEditar.VerticalScrollbarBarColor = true;
            this.tabEditar.VerticalScrollbarHighlightOnWheel = false;
            this.tabEditar.VerticalScrollbarSize = 10;
            // 
            // cmbTipoUtilizadorEditar
            // 
            this.cmbTipoUtilizadorEditar.FormattingEnabled = true;
            this.cmbTipoUtilizadorEditar.ItemHeight = 23;
            this.cmbTipoUtilizadorEditar.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cmbTipoUtilizadorEditar.Location = new System.Drawing.Point(553, 59);
            this.cmbTipoUtilizadorEditar.Name = "cmbTipoUtilizadorEditar";
            this.cmbTipoUtilizadorEditar.Size = new System.Drawing.Size(166, 29);
            this.cmbTipoUtilizadorEditar.TabIndex = 21;
            this.cmbTipoUtilizadorEditar.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(553, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Tipo de Utilizador :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(293, 112);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(57, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Secção :";
            // 
            // txtSeccaoEditar
            // 
            // 
            // 
            // 
            this.txtSeccaoEditar.CustomButton.Image = null;
            this.txtSeccaoEditar.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtSeccaoEditar.CustomButton.Name = "";
            this.txtSeccaoEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeccaoEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeccaoEditar.CustomButton.TabIndex = 1;
            this.txtSeccaoEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeccaoEditar.CustomButton.UseSelectable = true;
            this.txtSeccaoEditar.CustomButton.Visible = false;
            this.txtSeccaoEditar.Lines = new string[0];
            this.txtSeccaoEditar.Location = new System.Drawing.Point(293, 144);
            this.txtSeccaoEditar.MaxLength = 32767;
            this.txtSeccaoEditar.Name = "txtSeccaoEditar";
            this.txtSeccaoEditar.PasswordChar = '\0';
            this.txtSeccaoEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeccaoEditar.SelectedText = "";
            this.txtSeccaoEditar.SelectionLength = 0;
            this.txtSeccaoEditar.SelectionStart = 0;
            this.txtSeccaoEditar.ShortcutsEnabled = true;
            this.txtSeccaoEditar.Size = new System.Drawing.Size(166, 23);
            this.txtSeccaoEditar.TabIndex = 18;
            this.txtSeccaoEditar.UseSelectable = true;
            this.txtSeccaoEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeccaoEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(293, 27);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Nome de Utilizador :";
            // 
            // txtNomeUtilizadorEditar
            // 
            // 
            // 
            // 
            this.txtNomeUtilizadorEditar.CustomButton.Image = null;
            this.txtNomeUtilizadorEditar.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtNomeUtilizadorEditar.CustomButton.Name = "";
            this.txtNomeUtilizadorEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeUtilizadorEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUtilizadorEditar.CustomButton.TabIndex = 1;
            this.txtNomeUtilizadorEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeUtilizadorEditar.CustomButton.UseSelectable = true;
            this.txtNomeUtilizadorEditar.CustomButton.Visible = false;
            this.txtNomeUtilizadorEditar.Lines = new string[0];
            this.txtNomeUtilizadorEditar.Location = new System.Drawing.Point(293, 59);
            this.txtNomeUtilizadorEditar.MaxLength = 32767;
            this.txtNomeUtilizadorEditar.Name = "txtNomeUtilizadorEditar";
            this.txtNomeUtilizadorEditar.PasswordChar = '\0';
            this.txtNomeUtilizadorEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeUtilizadorEditar.SelectedText = "";
            this.txtNomeUtilizadorEditar.SelectionLength = 0;
            this.txtNomeUtilizadorEditar.SelectionStart = 0;
            this.txtNomeUtilizadorEditar.ShortcutsEnabled = true;
            this.txtNomeUtilizadorEditar.Size = new System.Drawing.Size(166, 23);
            this.txtNomeUtilizadorEditar.TabIndex = 16;
            this.txtNomeUtilizadorEditar.UseSelectable = true;
            this.txtNomeUtilizadorEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeUtilizadorEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(32, 112);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Password :";
            // 
            // txtPasswordEditar
            // 
            // 
            // 
            // 
            this.txtPasswordEditar.CustomButton.Image = null;
            this.txtPasswordEditar.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPasswordEditar.CustomButton.Name = "";
            this.txtPasswordEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordEditar.CustomButton.TabIndex = 1;
            this.txtPasswordEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordEditar.CustomButton.UseSelectable = true;
            this.txtPasswordEditar.CustomButton.Visible = false;
            this.txtPasswordEditar.Lines = new string[0];
            this.txtPasswordEditar.Location = new System.Drawing.Point(32, 144);
            this.txtPasswordEditar.MaxLength = 32767;
            this.txtPasswordEditar.Name = "txtPasswordEditar";
            this.txtPasswordEditar.PasswordChar = '\0';
            this.txtPasswordEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordEditar.SelectedText = "";
            this.txtPasswordEditar.SelectionLength = 0;
            this.txtPasswordEditar.SelectionStart = 0;
            this.txtPasswordEditar.ShortcutsEnabled = true;
            this.txtPasswordEditar.Size = new System.Drawing.Size(166, 23);
            this.txtPasswordEditar.TabIndex = 14;
            this.txtPasswordEditar.UseSelectable = true;
            this.txtPasswordEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(32, 27);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(116, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Nome Completo :";
            // 
            // txtNomeEditar
            // 
            // 
            // 
            // 
            this.txtNomeEditar.CustomButton.Image = null;
            this.txtNomeEditar.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtNomeEditar.CustomButton.Name = "";
            this.txtNomeEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeEditar.CustomButton.TabIndex = 1;
            this.txtNomeEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeEditar.CustomButton.UseSelectable = true;
            this.txtNomeEditar.CustomButton.Visible = false;
            this.txtNomeEditar.Lines = new string[0];
            this.txtNomeEditar.Location = new System.Drawing.Point(32, 59);
            this.txtNomeEditar.MaxLength = 32767;
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.PasswordChar = '\0';
            this.txtNomeEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeEditar.SelectedText = "";
            this.txtNomeEditar.SelectionLength = 0;
            this.txtNomeEditar.SelectionStart = 0;
            this.txtNomeEditar.ShortcutsEnabled = true;
            this.txtNomeEditar.Size = new System.Drawing.Size(166, 23);
            this.txtNomeEditar.TabIndex = 12;
            this.txtNomeEditar.UseSelectable = true;
            this.txtNomeEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton16
            // 
            this.metroButton16.BackgroundImage = global::Jardoeira.Properties.Resources.back_icon;
            this.metroButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton16.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton16.Location = new System.Drawing.Point(809, 339);
            this.metroButton16.Name = "metroButton16";
            this.metroButton16.Size = new System.Drawing.Size(99, 76);
            this.metroButton16.TabIndex = 12;
            this.metroButton16.UseSelectable = true;
            this.metroButton16.Click += new System.EventHandler(this.metroButton16_Click);
            // 
            // frmUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUtilizadores";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "Utilizadores";
            this.metroTabControl1.ResumeLayout(false);
            this.tabAdicionar.ResumeLayout(false);
            this.tabAdicionar.PerformLayout();
            this.tabEditar.ResumeLayout(false);
            this.tabEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabAdicionar;
        private MetroFramework.Controls.MetroTabPage tabEditar;
        private MetroFramework.Controls.MetroComboBox cmbTipoUtilizador;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSeccao;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUtilizador;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroComboBox cmbTipoUtilizadorEditar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSeccaoEditar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtNomeUtilizadorEditar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtPasswordEditar;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtNomeEditar;
        private MetroFramework.Controls.MetroButton metroButton16;
    }
}