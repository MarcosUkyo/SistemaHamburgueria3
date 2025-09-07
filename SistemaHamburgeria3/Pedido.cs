using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPizzaria2
{
    public partial class Pedido : Form
    {

        //INSTANCIANDO A CLASSE DE CONEXÃO
        Conexao con = new Conexao();

        public Pedido()
        {
            InitializeComponent();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            chkBacon.Checked = false;
            chkPicles.Checked = false;
            chkCebola.Checked = false;
            chkBarbecue.Checked = false;
            chkMaionese.Checked = false;

            txtValorOpcionais.Clear();
            txtValorPizza.Clear();
            txtValorPagar.Clear();
            cmbTamanhoPizza.SelectedIndex = 0;
        }

        private void grpBebidas_Enter(object sender, EventArgs e)
        {
            chkCoca.Checked = false;
            chkGuarana.Checked = false;
            chkSucoUva.Checked = false;
            chkSucoLaranja.Checked = false;
            chkEnergetico.Checked = false;

            txtValorOpcionais.Clear();
            txtValorPizza.Clear();
            txtValorPagar.Clear();
            cmbTamanhoPizza.SelectedIndex = 0;
        }

        private void grpAcompanhamento_Enter(object sender, EventArgs e)
        {
            chkBatataFrita.Checked = false;
            chkOnion.Checked = false;
            chkNuggets.Checked = false;
            chkSalada.Checked = false;
            chkBatataRustica.Checked = false;

            txtValorOpcionais.Clear();
            txtValorPizza.Clear();
            txtValorPagar.Clear();
            cmbTamanhoPizza.SelectedIndex = 0;
        }

        private void grpShakes_Enter(object sender, EventArgs e)
        {
            chkShakeChocolate.Checked = false;
            chkShakeMorango.Checked = false;
            chkSorveteBaunilha.Checked = false;
            chkSorveteChocolate.Checked = false;
            chkSundae.Checked = false;

            txtValorOpcionais.Clear();
            txtValorPizza.Clear();
            txtValorPagar.Clear();
            cmbTamanhoPizza.SelectedIndex = 0;
        }

        //MÉTODO QUE VAI CARREGAR AS INFORMAÇÕES NO DATAGRID
        private void Pedido_Load_1(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Normal- R$ 6,00");
            cmbTamanhoPizza.Items.Add("X-Salada - R$ 10,00");
            cmbTamanhoPizza.Items.Add("Carne Dupla R$ 12,00");
            cmbTamanhoPizza.Items.Add("Carne Dupla Gourmet - R$ 22,00");
            cmbTamanhoPizza.Items.Add("X-Tudo - R$ 25,00");
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //DECLARANDO AS VARIAVEIS
            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamanhoPizza.SelectedIndex == 0)
            {
                valorPizza = 6;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 1)
            {
                valorPizza = 10;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 2)
            {
                valorPizza = 12;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 3)
            {
                valorPizza = 22;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 4)
            {
                valorPizza = 25;
            }

            //OPCIONAIS
            if (chkBacon.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkBarbecue.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkPicles.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkMaionese.Checked == true)
            {
                valorOpcao = valorOpcao + 2;
            }

            //BEBIDAS
            if (chkCoca.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkGuarana.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkSucoUva.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkSucoLaranja.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkEnergetico.Checked == true)
            {
                valorOpcao = valorOpcao + 7;
            }

            //ACOMPANHAMENTO
            if (chkBatataFrita.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkOnion.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkNuggets.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkSalada.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkBatataRustica.Checked == true)
            {
                valorOpcao = valorOpcao + 12;
            }

            //SHAKES
            if (chkShakeChocolate.Checked == true)
            {
                valorOpcao = valorOpcao + 13;
            }
            if (chkShakeMorango.Checked == true)
            {
                valorOpcao = valorOpcao + 13;
            }
            if (chkSorveteBaunilha.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkSorveteChocolate.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkSundae.Checked == true)
            {
                valorOpcao = valorOpcao + 8;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            txtValorPizza.Text = Convert.ToString(valorPizza);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
            cmbTamanhoPizza.SelectedIndex = -1;
            txtValorPizza.Clear();
            txtValorOpcionais.Clear();
            chkBacon.Checked = false;
            chkPicles.Checked = false;
            chkCebola.Checked = false;
            chkBarbecue.Checked = false;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorPizza.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPizza.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido1(tipoHamburger,valorHamburger,valorOpcao,valorTotal) values(@hamburger,@vhamburger,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@hamburger", MySqlDbType.Text).Value = cmbTamanhoPizza.Text;
                    cmd.Parameters.Add("@vhamburger", MySqlDbType.Text).Value = txtValorPizza.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoPizza.Text = "";
                    txtValorPizza.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTamanhoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dgvPedido_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }

        public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanhoPizza.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorPizza.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }

        }

        private void txtCodPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido1";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPedido.DataSource = null;
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                Pedido ped = new Pedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

    }
}
