using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProjetoFloricultura
{
    public partial class Pedido : Form
    {
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            chkPelucia.Checked = false;
            chkCartao.Checked = false;
            chkBombons.Checked = false;

            txtValorOpcionais.Clear();
            txtValorBuque.Clear();
            txtValorPagar.Clear();
            cmbEscolheBuque.SelectedIndex = 0;
        }

     

        private void Pedido_Load(object sender, System.EventArgs e)
        {
            cmbEscolheBuque.Items.Add("12 Rosas- R$100,00");
            cmbEscolheBuque.Items.Add("24 Rosas- R$180,00");
            cmbEscolheBuque.Items.Add("42 Rosas- R$270,00");
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            double valorBuque = 0, valorOpcao = 0, valorTotal = 0;
            if (cmbEscolheBuque.SelectedIndex == 0)
            {
                valorBuque = 100;
            }
            else if (cmbEscolheBuque.SelectedIndex == 1)
            {
                valorBuque = 180;
            }
            else if (cmbEscolheBuque.SelectedIndex == 2)
            {
                valorBuque = 270;
            }
            if (chkPelucia.Checked == true)
            {
                valorOpcao = valorOpcao + 30;
            }
            if (chkCartao.Checked == true)
            {
                valorOpcao = valorOpcao + 10;
            }
            if (chkBombons.Checked == true)
            {
                valorOpcao = valorOpcao + 40;
            }
            else
            {
                MessageBox.Show("Pedido calculado com sucesso");  
            }
            valorTotal = valorBuque + valorOpcao;
            txtValorBuque.Text = Convert.ToString(valorBuque);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
            cmbEscolheBuque.SelectedIndex = -1;
            txtValorBuque.Clear();
            txtValorOpcionais.Clear();
            chkBombons.Checked = false;
            chkPelucia.Checked = false;
            chkCartao.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValorBuque.Text == "")
            {
                MessageBox.Show("Campo obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
                {
                MessageBox.Show("Campo obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                try
                {
                    string sql = "insert into tbPedido(tipoBuque,valorBuque,valorOpcao,valorTotal) values(@buque,@vbuque,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@buque", MySqlDbType.Text).Value = cmbEscolheBuque.Text;
                    cmd.Parameters.Add("@vbuque", MySqlDbType.Text).Value = txtValorBuque.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbEscolheBuque.Text = "";
                    txtValorBuque.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbEscolheBuque.Focus();
                    con.DesConnectarBD();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dgvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedido();
        }

        public void CarregarPedido()
        {
            try
            {
                txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbEscolheBuque.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorBuque.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

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
                dgvPedido.DataSource = null;
            }
            }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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