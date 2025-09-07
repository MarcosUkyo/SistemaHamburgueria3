namespace SistemaPizzaria2
{
    partial class Pedido
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.Label();
            this.txtCodPesquisar = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkMaionese = new System.Windows.Forms.CheckBox();
            this.chkBarbecue = new System.Windows.Forms.CheckBox();
            this.chkPicles = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grpBebidas = new System.Windows.Forms.GroupBox();
            this.chkEnergetico = new System.Windows.Forms.CheckBox();
            this.chkSucoUva = new System.Windows.Forms.CheckBox();
            this.chkSucoLaranja = new System.Windows.Forms.CheckBox();
            this.chkGuarana = new System.Windows.Forms.CheckBox();
            this.chkCoca = new System.Windows.Forms.CheckBox();
            this.grpAcompanhamento = new System.Windows.Forms.GroupBox();
            this.chkBatataRustica = new System.Windows.Forms.CheckBox();
            this.chkSalada = new System.Windows.Forms.CheckBox();
            this.chkNuggets = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkBatataFrita = new System.Windows.Forms.CheckBox();
            this.grpShakes = new System.Windows.Forms.GroupBox();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.chkSorveteChocolate = new System.Windows.Forms.CheckBox();
            this.chkSorveteBaunilha = new System.Windows.Forms.CheckBox();
            this.chkShakeMorango = new System.Windows.Forms.CheckBox();
            this.chkShakeChocolate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpBebidas.SuspendLayout();
            this.grpAcompanhamento.SuspendLayout();
            this.grpShakes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(410, 165);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(192, 20);
            this.txtCodigo.TabIndex = 49;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(614, 168);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(78, 13);
            this.txtPesquisar.TabIndex = 48;
            this.txtPesquisar.Text = "PESQUISAR";
            // 
            // txtCodPesquisar
            // 
            this.txtCodPesquisar.Location = new System.Drawing.Point(708, 165);
            this.txtCodPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPesquisar.Name = "txtCodPesquisar";
            this.txtCodPesquisar.Size = new System.Drawing.Size(192, 20);
            this.txtCodPesquisar.TabIndex = 47;
            this.txtCodPesquisar.TextChanged += new System.EventHandler(this.txtCodPesquisar_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(800, 409);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 54);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Chocolate;
            this.btnCalcular.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.Gold;
            this.btnCalcular.Location = new System.Drawing.Point(636, 409);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 54);
            this.btnCalcular.TabIndex = 45;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Chocolate;
            this.btnSalvar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Gold;
            this.btnSalvar.Location = new System.Drawing.Point(476, 409);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 54);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(571, 83);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(85, 20);
            this.txtValorOpcionais.TabIndex = 43;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(742, 83);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(85, 20);
            this.txtValorPagar.TabIndex = 42;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.Location = new System.Drawing.Point(739, 57);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(106, 13);
            this.lblValorPagar.TabIndex = 41;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOpcionais.Location = new System.Drawing.Point(568, 57);
            this.lblValorOpcionais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(149, 13);
            this.lblValorOpcionais.TabIndex = 40;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(410, 82);
            this.txtValorPizza.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(102, 20);
            this.txtValorPizza.TabIndex = 39;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkMaionese);
            this.grpOpcionais.Controls.Add(this.chkBarbecue);
            this.grpOpcionais.Controls.Add(this.chkPicles);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkBacon);
            this.grpOpcionais.Location = new System.Drawing.Point(9, 145);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Size = new System.Drawing.Size(130, 146);
            this.grpOpcionais.TabIndex = 38;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkMaionese
            // 
            this.chkMaionese.AutoSize = true;
            this.chkMaionese.Location = new System.Drawing.Point(4, 115);
            this.chkMaionese.Margin = new System.Windows.Forms.Padding(2);
            this.chkMaionese.Name = "chkMaionese";
            this.chkMaionese.Size = new System.Drawing.Size(113, 17);
            this.chkMaionese.TabIndex = 5;
            this.chkMaionese.Text = "Maionese De Alho";
            this.chkMaionese.UseVisualStyleBackColor = true;
            // 
            // chkBarbecue
            // 
            this.chkBarbecue.AutoSize = true;
            this.chkBarbecue.Location = new System.Drawing.Point(4, 94);
            this.chkBarbecue.Margin = new System.Windows.Forms.Padding(2);
            this.chkBarbecue.Name = "chkBarbecue";
            this.chkBarbecue.Size = new System.Drawing.Size(104, 17);
            this.chkBarbecue.TabIndex = 4;
            this.chkBarbecue.Text = "Molho Barbecue";
            this.chkBarbecue.UseVisualStyleBackColor = true;
            // 
            // chkPicles
            // 
            this.chkPicles.AutoSize = true;
            this.chkPicles.Location = new System.Drawing.Point(4, 73);
            this.chkPicles.Margin = new System.Windows.Forms.Padding(2);
            this.chkPicles.Name = "chkPicles";
            this.chkPicles.Size = new System.Drawing.Size(54, 17);
            this.chkPicles.TabIndex = 3;
            this.chkPicles.Text = "Picles";
            this.chkPicles.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(4, 52);
            this.chkCebola.Margin = new System.Windows.Forms.Padding(2);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(90, 17);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola Crispy";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(4, 31);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPizza.Location = new System.Drawing.Point(389, 57);
            this.lblValorPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(162, 13);
            this.lblValorPizza.TabIndex = 37;
            this.lblValorPizza.Text = "VALOR DO HAMBÚRGUER";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(339, 218);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(552, 158);
            this.dgvPedido.TabIndex = 36;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick_1);
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(48, 82);
            this.cmbTamanhoPizza.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(191, 21);
            this.cmbTamanhoPizza.TabIndex = 35;
            this.cmbTamanhoPizza.Text = "CARDÁPIO DOS HAMBÚRGUERS";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Chocolate;
            this.btnNovo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Gold;
            this.btnNovo.Location = new System.Drawing.Point(315, 409);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 54);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // grpBebidas
            // 
            this.grpBebidas.Controls.Add(this.chkEnergetico);
            this.grpBebidas.Controls.Add(this.chkSucoUva);
            this.grpBebidas.Controls.Add(this.chkSucoLaranja);
            this.grpBebidas.Controls.Add(this.chkGuarana);
            this.grpBebidas.Controls.Add(this.chkCoca);
            this.grpBebidas.Location = new System.Drawing.Point(151, 145);
            this.grpBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.grpBebidas.Name = "grpBebidas";
            this.grpBebidas.Padding = new System.Windows.Forms.Padding(2);
            this.grpBebidas.Size = new System.Drawing.Size(145, 146);
            this.grpBebidas.TabIndex = 39;
            this.grpBebidas.TabStop = false;
            this.grpBebidas.Text = "BEBIDAS";
            this.grpBebidas.Enter += new System.EventHandler(this.grpBebidas_Enter);
            // 
            // chkEnergetico
            // 
            this.chkEnergetico.AutoSize = true;
            this.chkEnergetico.Location = new System.Drawing.Point(4, 115);
            this.chkEnergetico.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnergetico.Name = "chkEnergetico";
            this.chkEnergetico.Size = new System.Drawing.Size(77, 17);
            this.chkEnergetico.TabIndex = 5;
            this.chkEnergetico.Text = "Energético";
            this.chkEnergetico.UseVisualStyleBackColor = true;
            // 
            // chkSucoUva
            // 
            this.chkSucoUva.AutoSize = true;
            this.chkSucoUva.Location = new System.Drawing.Point(4, 73);
            this.chkSucoUva.Margin = new System.Windows.Forms.Padding(2);
            this.chkSucoUva.Name = "chkSucoUva";
            this.chkSucoUva.Size = new System.Drawing.Size(91, 17);
            this.chkSucoUva.TabIndex = 4;
            this.chkSucoUva.Text = "Suco De Uva";
            this.chkSucoUva.UseVisualStyleBackColor = true;
            // 
            // chkSucoLaranja
            // 
            this.chkSucoLaranja.AutoSize = true;
            this.chkSucoLaranja.Location = new System.Drawing.Point(4, 94);
            this.chkSucoLaranja.Margin = new System.Windows.Forms.Padding(2);
            this.chkSucoLaranja.Name = "chkSucoLaranja";
            this.chkSucoLaranja.Size = new System.Drawing.Size(106, 17);
            this.chkSucoLaranja.TabIndex = 3;
            this.chkSucoLaranja.Text = "Suco De Laranja";
            this.chkSucoLaranja.UseVisualStyleBackColor = true;
            // 
            // chkGuarana
            // 
            this.chkGuarana.AutoSize = true;
            this.chkGuarana.Location = new System.Drawing.Point(4, 52);
            this.chkGuarana.Margin = new System.Windows.Forms.Padding(2);
            this.chkGuarana.Name = "chkGuarana";
            this.chkGuarana.Size = new System.Drawing.Size(67, 17);
            this.chkGuarana.TabIndex = 2;
            this.chkGuarana.Text = "Guaraná";
            this.chkGuarana.UseVisualStyleBackColor = true;
            // 
            // chkCoca
            // 
            this.chkCoca.AutoSize = true;
            this.chkCoca.Location = new System.Drawing.Point(4, 31);
            this.chkCoca.Margin = new System.Windows.Forms.Padding(2);
            this.chkCoca.Name = "chkCoca";
            this.chkCoca.Size = new System.Drawing.Size(75, 17);
            this.chkCoca.TabIndex = 1;
            this.chkCoca.Text = "Coca-Cola";
            this.chkCoca.UseVisualStyleBackColor = true;
            // 
            // grpAcompanhamento
            // 
            this.grpAcompanhamento.Controls.Add(this.chkBatataRustica);
            this.grpAcompanhamento.Controls.Add(this.chkSalada);
            this.grpAcompanhamento.Controls.Add(this.chkNuggets);
            this.grpAcompanhamento.Controls.Add(this.chkOnion);
            this.grpAcompanhamento.Controls.Add(this.chkBatataFrita);
            this.grpAcompanhamento.Location = new System.Drawing.Point(9, 317);
            this.grpAcompanhamento.Margin = new System.Windows.Forms.Padding(2);
            this.grpAcompanhamento.Name = "grpAcompanhamento";
            this.grpAcompanhamento.Padding = new System.Windows.Forms.Padding(2);
            this.grpAcompanhamento.Size = new System.Drawing.Size(130, 146);
            this.grpAcompanhamento.TabIndex = 39;
            this.grpAcompanhamento.TabStop = false;
            this.grpAcompanhamento.Text = "ACOMPANHAMENTO";
            this.grpAcompanhamento.Enter += new System.EventHandler(this.grpAcompanhamento_Enter);
            // 
            // chkBatataRustica
            // 
            this.chkBatataRustica.AutoSize = true;
            this.chkBatataRustica.Location = new System.Drawing.Point(4, 115);
            this.chkBatataRustica.Margin = new System.Windows.Forms.Padding(2);
            this.chkBatataRustica.Name = "chkBatataRustica";
            this.chkBatataRustica.Size = new System.Drawing.Size(96, 17);
            this.chkBatataRustica.TabIndex = 5;
            this.chkBatataRustica.Text = "Batata Rústica";
            this.chkBatataRustica.UseVisualStyleBackColor = true;
            // 
            // chkSalada
            // 
            this.chkSalada.AutoSize = true;
            this.chkSalada.Location = new System.Drawing.Point(4, 94);
            this.chkSalada.Margin = new System.Windows.Forms.Padding(2);
            this.chkSalada.Name = "chkSalada";
            this.chkSalada.Size = new System.Drawing.Size(59, 17);
            this.chkSalada.TabIndex = 4;
            this.chkSalada.Text = "Salada";
            this.chkSalada.UseVisualStyleBackColor = true;
            // 
            // chkNuggets
            // 
            this.chkNuggets.AutoSize = true;
            this.chkNuggets.Location = new System.Drawing.Point(4, 73);
            this.chkNuggets.Margin = new System.Windows.Forms.Padding(2);
            this.chkNuggets.Name = "chkNuggets";
            this.chkNuggets.Size = new System.Drawing.Size(66, 17);
            this.chkNuggets.TabIndex = 3;
            this.chkNuggets.Text = "Nuggets";
            this.chkNuggets.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(4, 52);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(84, 17);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion Rings";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkBatataFrita
            // 
            this.chkBatataFrita.AutoSize = true;
            this.chkBatataFrita.Location = new System.Drawing.Point(4, 31);
            this.chkBatataFrita.Margin = new System.Windows.Forms.Padding(2);
            this.chkBatataFrita.Name = "chkBatataFrita";
            this.chkBatataFrita.Size = new System.Drawing.Size(80, 17);
            this.chkBatataFrita.TabIndex = 1;
            this.chkBatataFrita.Text = "Batata Frita";
            this.chkBatataFrita.UseVisualStyleBackColor = true;
            // 
            // grpShakes
            // 
            this.grpShakes.Controls.Add(this.chkSundae);
            this.grpShakes.Controls.Add(this.chkSorveteChocolate);
            this.grpShakes.Controls.Add(this.chkSorveteBaunilha);
            this.grpShakes.Controls.Add(this.chkShakeMorango);
            this.grpShakes.Controls.Add(this.chkShakeChocolate);
            this.grpShakes.Location = new System.Drawing.Point(151, 317);
            this.grpShakes.Margin = new System.Windows.Forms.Padding(2);
            this.grpShakes.Name = "grpShakes";
            this.grpShakes.Padding = new System.Windows.Forms.Padding(2);
            this.grpShakes.Size = new System.Drawing.Size(145, 146);
            this.grpShakes.TabIndex = 39;
            this.grpShakes.TabStop = false;
            this.grpShakes.Text = "SOBREMESAS E SHAKES";
            this.grpShakes.Enter += new System.EventHandler(this.grpShakes_Enter);
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(4, 115);
            this.chkSundae.Margin = new System.Windows.Forms.Padding(2);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(63, 17);
            this.chkSundae.TabIndex = 5;
            this.chkSundae.Text = "Sundae";
            this.chkSundae.UseVisualStyleBackColor = true;
            // 
            // chkSorveteChocolate
            // 
            this.chkSorveteChocolate.AutoSize = true;
            this.chkSorveteChocolate.Location = new System.Drawing.Point(4, 94);
            this.chkSorveteChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.chkSorveteChocolate.Name = "chkSorveteChocolate";
            this.chkSorveteChocolate.Size = new System.Drawing.Size(131, 17);
            this.chkSorveteChocolate.TabIndex = 4;
            this.chkSorveteChocolate.Text = "Sorvete De Chocolate";
            this.chkSorveteChocolate.UseVisualStyleBackColor = true;
            // 
            // chkSorveteBaunilha
            // 
            this.chkSorveteBaunilha.AutoSize = true;
            this.chkSorveteBaunilha.Location = new System.Drawing.Point(4, 73);
            this.chkSorveteBaunilha.Margin = new System.Windows.Forms.Padding(2);
            this.chkSorveteBaunilha.Name = "chkSorveteBaunilha";
            this.chkSorveteBaunilha.Size = new System.Drawing.Size(124, 17);
            this.chkSorveteBaunilha.TabIndex = 3;
            this.chkSorveteBaunilha.Text = "Sorvete De Baunilha";
            this.chkSorveteBaunilha.UseVisualStyleBackColor = true;
            // 
            // chkShakeMorango
            // 
            this.chkShakeMorango.AutoSize = true;
            this.chkShakeMorango.Location = new System.Drawing.Point(4, 52);
            this.chkShakeMorango.Margin = new System.Windows.Forms.Padding(2);
            this.chkShakeMorango.Name = "chkShakeMorango";
            this.chkShakeMorango.Size = new System.Drawing.Size(139, 17);
            this.chkShakeMorango.TabIndex = 2;
            this.chkShakeMorango.Text = "Milk-shake De Morango";
            this.chkShakeMorango.UseVisualStyleBackColor = true;
            // 
            // chkShakeChocolate
            // 
            this.chkShakeChocolate.AutoSize = true;
            this.chkShakeChocolate.Location = new System.Drawing.Point(4, 31);
            this.chkShakeChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.chkShakeChocolate.Name = "chkShakeChocolate";
            this.chkShakeChocolate.Size = new System.Drawing.Size(145, 17);
            this.chkShakeChocolate.TabIndex = 1;
            this.chkShakeChocolate.Text = "Milk-shake De Chocolate";
            this.chkShakeChocolate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "CÓDIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaHamburgeria3.Properties.Resources._34fafcb8_6fd2_4470_86ce_b89322847a13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpShakes);
            this.Controls.Add(this.grpAcompanhamento);
            this.Controls.Add(this.grpBebidas);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.btnNovo);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load_1);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpBebidas.ResumeLayout(false);
            this.grpBebidas.PerformLayout();
            this.grpAcompanhamento.ResumeLayout(false);
            this.grpAcompanhamento.PerformLayout();
            this.grpShakes.ResumeLayout(false);
            this.grpShakes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label txtPesquisar;
        private System.Windows.Forms.TextBox txtCodPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkBarbecue;
        private System.Windows.Forms.CheckBox chkPicles;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grpBebidas;
        private System.Windows.Forms.CheckBox chkSucoUva;
        private System.Windows.Forms.CheckBox chkSucoLaranja;
        private System.Windows.Forms.CheckBox chkGuarana;
        private System.Windows.Forms.CheckBox chkCoca;
        private System.Windows.Forms.GroupBox grpAcompanhamento;
        private System.Windows.Forms.CheckBox chkSalada;
        private System.Windows.Forms.CheckBox chkNuggets;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkBatataFrita;
        private System.Windows.Forms.GroupBox grpShakes;
        private System.Windows.Forms.CheckBox chkSorveteChocolate;
        private System.Windows.Forms.CheckBox chkSorveteBaunilha;
        private System.Windows.Forms.CheckBox chkShakeMorango;
        private System.Windows.Forms.CheckBox chkShakeChocolate;
        private System.Windows.Forms.CheckBox chkMaionese;
        private System.Windows.Forms.CheckBox chkEnergetico;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.CheckBox chkBatataRustica;
        private System.Windows.Forms.Label label1;
    }
}