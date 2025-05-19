using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PDV.cadastro
{
    public partial class FrmCargo : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id;
        string nomeAntigo;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Listar();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ScrollBars = ScrollBars.Vertical;
        }
        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargos";
            grid.Columns[2].HeaderText = "Data";
            grid.Columns[0].Visible = false;
        }
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o cargo: " + nomeAntigo + " ?", "Cadastro de Cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                MessageBox.Show("Cargo excluído com sucesso!", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                LimparCampos();
                Listar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome do Cargo.", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtNome.Text != nomeAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE cargo = @cargo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cargo", txtNome.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("O cargo \"" + txtNome.Text + "\" já está cadastrado.", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNome.Text = "";
                    txtNome.Focus();
                    btnEditar.Enabled = false;
                    txtNome.Enabled = false;
                    return;
                }
            }

            con.AbrirConexao();

            sql = "INSERT INTO cargos(cargo, data) VALUES(@cargo,curDate())";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@cargo", txtNome.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();
            LimparCampos();
            Listar();

            MessageBox.Show("Cargo salvo com sucesso!", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Enabled = false;
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome do Cargo.", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            
            con.AbrirConexao();


                sql = "UPDATE cargos SET cargo = @cargo WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cargo", txtNome.Text);

            if (txtNome.Text != nomeAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE cargo = @cargo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cargo", txtNome.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("O cargo \"" + txtNome.Text + "\" já está cadastrado.", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtNome.Text = "";
                    txtNome.Focus();
                    btnEditar.Enabled = false;
                    txtNome.Enabled = false;
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();
            LimparCampos();

            MessageBox.Show("Cargo editado com sucesso!", "Cadastro de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
                txtNome.Enabled = true;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                nomeAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }// FIM
}
