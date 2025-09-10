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
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.txtCodPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkPicles = new System.Windows.Forms.CheckBox();
            this.chkBarbecue = new System.Windows.Forms.CheckBox();
            this.chkMaionese = new System.Windows.Forms.CheckBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkShakeChocolate = new System.Windows.Forms.CheckBox();
            this.chkShakeMorango = new System.Windows.Forms.CheckBox();
            this.chkSorveteBaunilha = new System.Windows.Forms.CheckBox();
            this.chkSorveteChocolate = new System.Windows.Forms.CheckBox();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.grpShakes = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.Label();
            this.chkBatataFrita = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkNuggets = new System.Windows.Forms.CheckBox();
            this.chkSalada = new System.Windows.Forms.CheckBox();
            this.chkBatataRustica = new System.Windows.Forms.CheckBox();
            this.grpAcompanhamento = new System.Windows.Forms.GroupBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.chkCoca = new System.Windows.Forms.CheckBox();
            this.chkGuarana = new System.Windows.Forms.CheckBox();
            this.chkSucoLaranja = new System.Windows.Forms.CheckBox();
            this.chkSucoUva = new System.Windows.Forms.CheckBox();
            this.chkEnergetico = new System.Windows.Forms.CheckBox();
            this.grpBebidas = new System.Windows.Forms.GroupBox();
            this.grpOpcionais.SuspendLayout();
            this.grpShakes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpAcompanhamento.SuspendLayout();
            this.grpBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.BackColor = System.Drawing.Color.Chocolate;
            this.lblValorPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblValorPizza.ForeColor = System.Drawing.Color.Gold;
            this.lblValorPizza.Location = new System.Drawing.Point(420, 70);
            this.lblValorPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(197, 18);
            this.lblValorPizza.TabIndex = 37;
            this.lblValorPizza.Text = "VALOR DO HAMBÚRGUER";
            // 
            // txtCodPesquisar
            // 
            this.txtCodPesquisar.BackColor = System.Drawing.Color.Chocolate;
            this.txtCodPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCodPesquisar.ForeColor = System.Drawing.Color.Gold;
            this.txtCodPesquisar.Location = new System.Drawing.Point(783, 178);
            this.txtCodPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPesquisar.Name = "txtCodPesquisar";
            this.txtCodPesquisar.Size = new System.Drawing.Size(192, 24);
            this.txtCodPesquisar.TabIndex = 47;
            this.txtCodPesquisar.TextChanged += new System.EventHandler(this.txtCodPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(395, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "CÓDIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.BackColor = System.Drawing.Color.Chocolate;
            this.cmbTamanhoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamanhoPizza.ForeColor = System.Drawing.Color.Gold;
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(30, 70);
            this.cmbTamanhoPizza.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(246, 24);
            this.cmbTamanhoPizza.TabIndex = 35;
            this.cmbTamanhoPizza.Text = "CARDÁPIO DOS HAMBÚRGUERS";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Chocolate;
            this.btnNovo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Gold;
            this.btnNovo.Location = new System.Drawing.Point(423, 422);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 54);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.BackColor = System.Drawing.Color.Chocolate;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblValorPagar.ForeColor = System.Drawing.Color.Gold;
            this.lblValorPagar.Location = new System.Drawing.Point(825, 70);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(125, 18);
            this.lblValorPagar.TabIndex = 41;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.BackColor = System.Drawing.Color.Chocolate;
            this.txtValorOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtValorOpcionais.ForeColor = System.Drawing.Color.Gold;
            this.txtValorOpcionais.Location = new System.Drawing.Point(654, 96);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(125, 24);
            this.txtValorOpcionais.TabIndex = 43;
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.BackColor = System.Drawing.Color.Chocolate;
            this.lblValorOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblValorOpcionais.ForeColor = System.Drawing.Color.Gold;
            this.lblValorOpcionais.Location = new System.Drawing.Point(632, 70);
            this.lblValorOpcionais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(179, 18);
            this.lblValorOpcionais.TabIndex = 40;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.BackColor = System.Drawing.Color.Chocolate;
            this.txtValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtValorPagar.ForeColor = System.Drawing.Color.Gold;
            this.txtValorPagar.Location = new System.Drawing.Point(838, 96);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(103, 24);
            this.txtValorPagar.TabIndex = 42;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Chocolate;
            this.btnCalcular.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.Gold;
            this.btnCalcular.Location = new System.Drawing.Point(722, 422);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 54);
            this.btnCalcular.TabIndex = 45;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(4, 31);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(65, 20);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(4, 52);
            this.chkCebola.Margin = new System.Windows.Forms.Padding(2);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 20);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola Crispy";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkPicles
            // 
            this.chkPicles.AutoSize = true;
            this.chkPicles.Location = new System.Drawing.Point(4, 73);
            this.chkPicles.Margin = new System.Windows.Forms.Padding(2);
            this.chkPicles.Name = "chkPicles";
            this.chkPicles.Size = new System.Drawing.Size(63, 20);
            this.chkPicles.TabIndex = 3;
            this.chkPicles.Text = "Picles";
            this.chkPicles.UseVisualStyleBackColor = true;
            // 
            // chkBarbecue
            // 
            this.chkBarbecue.AutoSize = true;
            this.chkBarbecue.Location = new System.Drawing.Point(4, 94);
            this.chkBarbecue.Margin = new System.Windows.Forms.Padding(2);
            this.chkBarbecue.Name = "chkBarbecue";
            this.chkBarbecue.Size = new System.Drawing.Size(125, 20);
            this.chkBarbecue.TabIndex = 4;
            this.chkBarbecue.Text = "Molho Barbecue";
            this.chkBarbecue.UseVisualStyleBackColor = true;
            // 
            // chkMaionese
            // 
            this.chkMaionese.AutoSize = true;
            this.chkMaionese.Location = new System.Drawing.Point(4, 115);
            this.chkMaionese.Margin = new System.Windows.Forms.Padding(2);
            this.chkMaionese.Name = "chkMaionese";
            this.chkMaionese.Size = new System.Drawing.Size(137, 20);
            this.chkMaionese.TabIndex = 5;
            this.chkMaionese.Text = "Maionese De Alho";
            this.chkMaionese.UseVisualStyleBackColor = true;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.BackColor = System.Drawing.Color.Chocolate;
            this.grpOpcionais.Controls.Add(this.chkMaionese);
            this.grpOpcionais.Controls.Add(this.chkBarbecue);
            this.grpOpcionais.Controls.Add(this.chkPicles);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkBacon);
            this.grpOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcionais.ForeColor = System.Drawing.Color.Gold;
            this.grpOpcionais.Location = new System.Drawing.Point(9, 145);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Size = new System.Drawing.Size(172, 146);
            this.grpOpcionais.TabIndex = 38;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkShakeChocolate
            // 
            this.chkShakeChocolate.AutoSize = true;
            this.chkShakeChocolate.Location = new System.Drawing.Point(4, 31);
            this.chkShakeChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.chkShakeChocolate.Name = "chkShakeChocolate";
            this.chkShakeChocolate.Size = new System.Drawing.Size(176, 20);
            this.chkShakeChocolate.TabIndex = 1;
            this.chkShakeChocolate.Text = "Milk-shake De Chocolate";
            this.chkShakeChocolate.UseVisualStyleBackColor = true;
            // 
            // chkShakeMorango
            // 
            this.chkShakeMorango.AutoSize = true;
            this.chkShakeMorango.Location = new System.Drawing.Point(4, 52);
            this.chkShakeMorango.Margin = new System.Windows.Forms.Padding(2);
            this.chkShakeMorango.Name = "chkShakeMorango";
            this.chkShakeMorango.Size = new System.Drawing.Size(169, 20);
            this.chkShakeMorango.TabIndex = 2;
            this.chkShakeMorango.Text = "Milk-shake De Morango";
            this.chkShakeMorango.UseVisualStyleBackColor = true;
            // 
            // chkSorveteBaunilha
            // 
            this.chkSorveteBaunilha.AutoSize = true;
            this.chkSorveteBaunilha.Location = new System.Drawing.Point(4, 73);
            this.chkSorveteBaunilha.Margin = new System.Windows.Forms.Padding(2);
            this.chkSorveteBaunilha.Name = "chkSorveteBaunilha";
            this.chkSorveteBaunilha.Size = new System.Drawing.Size(149, 20);
            this.chkSorveteBaunilha.TabIndex = 3;
            this.chkSorveteBaunilha.Text = "Sorvete De Baunilha";
            this.chkSorveteBaunilha.UseVisualStyleBackColor = true;
            // 
            // chkSorveteChocolate
            // 
            this.chkSorveteChocolate.AutoSize = true;
            this.chkSorveteChocolate.Location = new System.Drawing.Point(4, 94);
            this.chkSorveteChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.chkSorveteChocolate.Name = "chkSorveteChocolate";
            this.chkSorveteChocolate.Size = new System.Drawing.Size(158, 20);
            this.chkSorveteChocolate.TabIndex = 4;
            this.chkSorveteChocolate.Text = "Sorvete De Chocolate";
            this.chkSorveteChocolate.UseVisualStyleBackColor = true;
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(4, 115);
            this.chkSundae.Margin = new System.Windows.Forms.Padding(2);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(73, 20);
            this.chkSundae.TabIndex = 5;
            this.chkSundae.Text = "Sundae";
            this.chkSundae.UseVisualStyleBackColor = true;
            // 
            // grpShakes
            // 
            this.grpShakes.BackColor = System.Drawing.Color.Chocolate;
            this.grpShakes.Controls.Add(this.chkSundae);
            this.grpShakes.Controls.Add(this.chkSorveteChocolate);
            this.grpShakes.Controls.Add(this.chkSorveteBaunilha);
            this.grpShakes.Controls.Add(this.chkShakeMorango);
            this.grpShakes.Controls.Add(this.chkShakeChocolate);
            this.grpShakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShakes.ForeColor = System.Drawing.Color.Gold;
            this.grpShakes.Location = new System.Drawing.Point(199, 317);
            this.grpShakes.Margin = new System.Windows.Forms.Padding(2);
            this.grpShakes.Name = "grpShakes";
            this.grpShakes.Padding = new System.Windows.Forms.Padding(2);
            this.grpShakes.Size = new System.Drawing.Size(172, 146);
            this.grpShakes.TabIndex = 39;
            this.grpShakes.TabStop = false;
            this.grpShakes.Text = "SOBREMESAS E SHAKES";
            this.grpShakes.Enter += new System.EventHandler(this.grpShakes_Enter);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Chocolate;
            this.btnSalvar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Gold;
            this.btnSalvar.Location = new System.Drawing.Point(569, 422);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 54);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.Chocolate;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(423, 231);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(552, 158);
            this.dgvPedido.TabIndex = 36;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Chocolate;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Gold;
            this.txtCodigo.Location = new System.Drawing.Point(469, 178);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(192, 24);
            this.txtCodigo.TabIndex = 49;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(859, 422);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 54);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.BackColor = System.Drawing.Color.Chocolate;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gold;
            this.txtPesquisar.Location = new System.Drawing.Point(685, 181);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(94, 18);
            this.txtPesquisar.TabIndex = 48;
            this.txtPesquisar.Text = "PESQUISAR";
            // 
            // chkBatataFrita
            // 
            this.chkBatataFrita.AutoSize = true;
            this.chkBatataFrita.Location = new System.Drawing.Point(4, 31);
            this.chkBatataFrita.Margin = new System.Windows.Forms.Padding(2);
            this.chkBatataFrita.Name = "chkBatataFrita";
            this.chkBatataFrita.Size = new System.Drawing.Size(94, 20);
            this.chkBatataFrita.TabIndex = 1;
            this.chkBatataFrita.Text = "Batata Frita";
            this.chkBatataFrita.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(4, 52);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(99, 20);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion Rings";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkNuggets
            // 
            this.chkNuggets.AutoSize = true;
            this.chkNuggets.Location = new System.Drawing.Point(4, 73);
            this.chkNuggets.Margin = new System.Windows.Forms.Padding(2);
            this.chkNuggets.Name = "chkNuggets";
            this.chkNuggets.Size = new System.Drawing.Size(77, 20);
            this.chkNuggets.TabIndex = 3;
            this.chkNuggets.Text = "Nuggets";
            this.chkNuggets.UseVisualStyleBackColor = true;
            // 
            // chkSalada
            // 
            this.chkSalada.AutoSize = true;
            this.chkSalada.Location = new System.Drawing.Point(4, 94);
            this.chkSalada.Margin = new System.Windows.Forms.Padding(2);
            this.chkSalada.Name = "chkSalada";
            this.chkSalada.Size = new System.Drawing.Size(70, 20);
            this.chkSalada.TabIndex = 4;
            this.chkSalada.Text = "Salada";
            this.chkSalada.UseVisualStyleBackColor = true;
            // 
            // chkBatataRustica
            // 
            this.chkBatataRustica.AutoSize = true;
            this.chkBatataRustica.Location = new System.Drawing.Point(4, 115);
            this.chkBatataRustica.Margin = new System.Windows.Forms.Padding(2);
            this.chkBatataRustica.Name = "chkBatataRustica";
            this.chkBatataRustica.Size = new System.Drawing.Size(113, 20);
            this.chkBatataRustica.TabIndex = 5;
            this.chkBatataRustica.Text = "Batata Rústica";
            this.chkBatataRustica.UseVisualStyleBackColor = true;
            // 
            // grpAcompanhamento
            // 
            this.grpAcompanhamento.BackColor = System.Drawing.Color.Chocolate;
            this.grpAcompanhamento.Controls.Add(this.chkBatataRustica);
            this.grpAcompanhamento.Controls.Add(this.chkSalada);
            this.grpAcompanhamento.Controls.Add(this.chkNuggets);
            this.grpAcompanhamento.Controls.Add(this.chkOnion);
            this.grpAcompanhamento.Controls.Add(this.chkBatataFrita);
            this.grpAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcompanhamento.ForeColor = System.Drawing.Color.Gold;
            this.grpAcompanhamento.Location = new System.Drawing.Point(9, 317);
            this.grpAcompanhamento.Margin = new System.Windows.Forms.Padding(2);
            this.grpAcompanhamento.Name = "grpAcompanhamento";
            this.grpAcompanhamento.Padding = new System.Windows.Forms.Padding(2);
            this.grpAcompanhamento.Size = new System.Drawing.Size(172, 146);
            this.grpAcompanhamento.TabIndex = 39;
            this.grpAcompanhamento.TabStop = false;
            this.grpAcompanhamento.Text = "ACOMPANHAMENTO";
            this.grpAcompanhamento.Enter += new System.EventHandler(this.grpAcompanhamento_Enter);
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.BackColor = System.Drawing.Color.Chocolate;
            this.txtValorPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtValorPizza.ForeColor = System.Drawing.Color.Gold;
            this.txtValorPizza.Location = new System.Drawing.Point(444, 95);
            this.txtValorPizza.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(148, 24);
            this.txtValorPizza.TabIndex = 39;
            // 
            // chkCoca
            // 
            this.chkCoca.AutoSize = true;
            this.chkCoca.Location = new System.Drawing.Point(4, 31);
            this.chkCoca.Margin = new System.Windows.Forms.Padding(2);
            this.chkCoca.Name = "chkCoca";
            this.chkCoca.Size = new System.Drawing.Size(90, 20);
            this.chkCoca.TabIndex = 1;
            this.chkCoca.Text = "Coca-Cola";
            this.chkCoca.UseVisualStyleBackColor = true;
            // 
            // chkGuarana
            // 
            this.chkGuarana.AutoSize = true;
            this.chkGuarana.Location = new System.Drawing.Point(4, 52);
            this.chkGuarana.Margin = new System.Windows.Forms.Padding(2);
            this.chkGuarana.Name = "chkGuarana";
            this.chkGuarana.Size = new System.Drawing.Size(78, 20);
            this.chkGuarana.TabIndex = 2;
            this.chkGuarana.Text = "Guaraná";
            this.chkGuarana.UseVisualStyleBackColor = true;
            // 
            // chkSucoLaranja
            // 
            this.chkSucoLaranja.AutoSize = true;
            this.chkSucoLaranja.Location = new System.Drawing.Point(4, 94);
            this.chkSucoLaranja.Margin = new System.Windows.Forms.Padding(2);
            this.chkSucoLaranja.Name = "chkSucoLaranja";
            this.chkSucoLaranja.Size = new System.Drawing.Size(126, 20);
            this.chkSucoLaranja.TabIndex = 3;
            this.chkSucoLaranja.Text = "Suco De Laranja";
            this.chkSucoLaranja.UseVisualStyleBackColor = true;
            // 
            // chkSucoUva
            // 
            this.chkSucoUva.AutoSize = true;
            this.chkSucoUva.Location = new System.Drawing.Point(4, 73);
            this.chkSucoUva.Margin = new System.Windows.Forms.Padding(2);
            this.chkSucoUva.Name = "chkSucoUva";
            this.chkSucoUva.Size = new System.Drawing.Size(106, 20);
            this.chkSucoUva.TabIndex = 4;
            this.chkSucoUva.Text = "Suco De Uva";
            this.chkSucoUva.UseVisualStyleBackColor = true;
            // 
            // chkEnergetico
            // 
            this.chkEnergetico.AutoSize = true;
            this.chkEnergetico.Location = new System.Drawing.Point(4, 115);
            this.chkEnergetico.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnergetico.Name = "chkEnergetico";
            this.chkEnergetico.Size = new System.Drawing.Size(91, 20);
            this.chkEnergetico.TabIndex = 5;
            this.chkEnergetico.Text = "Energético";
            this.chkEnergetico.UseVisualStyleBackColor = true;
            // 
            // grpBebidas
            // 
            this.grpBebidas.BackColor = System.Drawing.Color.Chocolate;
            this.grpBebidas.Controls.Add(this.chkEnergetico);
            this.grpBebidas.Controls.Add(this.chkSucoUva);
            this.grpBebidas.Controls.Add(this.chkSucoLaranja);
            this.grpBebidas.Controls.Add(this.chkGuarana);
            this.grpBebidas.Controls.Add(this.chkCoca);
            this.grpBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBebidas.ForeColor = System.Drawing.Color.Gold;
            this.grpBebidas.Location = new System.Drawing.Point(199, 145);
            this.grpBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.grpBebidas.Name = "grpBebidas";
            this.grpBebidas.Padding = new System.Windows.Forms.Padding(2);
            this.grpBebidas.Size = new System.Drawing.Size(172, 146);
            this.grpBebidas.TabIndex = 39;
            this.grpBebidas.TabStop = false;
            this.grpBebidas.Text = "BEBIDAS";
            this.grpBebidas.Enter += new System.EventHandler(this.grpBebidas_Enter);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaHamburgeria3.Properties.Resources._34fafcb8_6fd2_4470_86ce_b89322847a13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 525);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load_1);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.grpShakes.ResumeLayout(false);
            this.grpShakes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpAcompanhamento.ResumeLayout(false);
            this.grpAcompanhamento.PerformLayout();
            this.grpBebidas.ResumeLayout(false);
            this.grpBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.TextBox txtCodPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkPicles;
        private System.Windows.Forms.CheckBox chkBarbecue;
        private System.Windows.Forms.CheckBox chkMaionese;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkShakeChocolate;
        private System.Windows.Forms.CheckBox chkShakeMorango;
        private System.Windows.Forms.CheckBox chkSorveteBaunilha;
        private System.Windows.Forms.CheckBox chkSorveteChocolate;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.GroupBox grpShakes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label txtPesquisar;
        private System.Windows.Forms.CheckBox chkBatataFrita;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkNuggets;
        private System.Windows.Forms.CheckBox chkSalada;
        private System.Windows.Forms.CheckBox chkBatataRustica;
        private System.Windows.Forms.GroupBox grpAcompanhamento;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.CheckBox chkCoca;
        private System.Windows.Forms.CheckBox chkGuarana;
        private System.Windows.Forms.CheckBox chkSucoLaranja;
        private System.Windows.Forms.CheckBox chkSucoUva;
        private System.Windows.Forms.CheckBox chkEnergetico;
        private System.Windows.Forms.GroupBox grpBebidas;
    }
}