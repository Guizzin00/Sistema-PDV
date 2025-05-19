using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class GZNFuncionarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string foto;
        string alterouImagem = "nao";
        string id;
        string cpfAntigo;

        public GZNFuncionarios()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ScrollBars = ScrollBars.Vertical;
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();

            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
            cmd.Parameters.AddWithValue("@foto", img());

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();
            Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            DesabilitarCampos();
            LimparCampos();



        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
                alterouImagem = "sim";
            }
        }

        private byte[] img()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;

        }

        private void LimparFoto()
        {
            image.Image = Properties.Resources.sem_foto;
            foto = "imagens/sem-foto.png";
        }

        private void GZNFuncionarios_Load(object sender, EventArgs e)
        {
            LimparFoto();
            ListarCargos();
            Listar();
            alterouImagem = "nao";
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Tel.:";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Imagem";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = true;
            grid.Columns[7].Visible = true;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtNome.Focus();
        }

        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEnd.Enabled = true;
            txtTel.Enabled = true;
            btnFoto.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEnd.Enabled = false;
            txtTel.Enabled = false;
            cbCargo.Enabled = false;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEnd.Text = "";
            txtTel.Text = "";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                habilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txtEnd.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if (grid.CurrentRow.Cells[7].Value != DBNull.Value) 
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imagem);

                    image.Image = Image.FromStream(ms);
                }
                else
                {
                    image.Image = Properties.Resources.sem_foto;
                }

            }
            else
            {
                return;
            }
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCpf.Text == "   .   .   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();
            if (alterouImagem == "sim")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
                cmd.Parameters.AddWithValue("@foto", img());
            }
            else if (alterouImagem == "nao")
            {

                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);

            }

            if (txtCpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE cpf = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf", txtCpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado", "Cadastro de Funiconários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }

            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            alterouImagem = "nao";
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Cadastro funcionários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {              
                con.AbrirConexao();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro Funiconários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                LimparFoto();
                Listar();
            }
        }
        private void ListarCargos()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCargo.DataSource = dt;
            //cbCargo.ValueMember = "id";
            cbCargo.DisplayMember = "cargo";
            con.FecharConexao();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } //FIM DO PROJETO
}