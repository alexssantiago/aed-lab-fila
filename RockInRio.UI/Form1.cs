using RockInRio.Dominio;
using System;
using System.Windows.Forms;

namespace RockInRio.UI
{
    public partial class Form1 : Form
    {
        readonly Fila fila;

        public Form1()
        {
            InitializeComponent();
            this.fila = new Fila();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
        }

        private void InserirNaFila(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text
            };

            fila.Inserir(usuario);

            MessageBox.Show($"{usuario.Nome} entrou na fila.");

            dgvUsuarios.Rows.Add(usuario.Nome, usuario.Cpf);
            LimparCampos();
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection gridRow = dgvUsuarios.SelectedRows;

            foreach (DataGridViewRow row in gridRow)
            {
                txtNome.Text = dgvUsuarios.Rows[row.Index].Cells["Nome"].Value.ToString();
                txtCpf.Text = dgvUsuarios.Rows[row.Index].Cells["CPF"].Value.ToString();
            }
            btnInserir.Enabled = false;
            btnRemover.Enabled = true;
        }

        private void RemoverDaFila(object sender, EventArgs e)
        {
            Usuario usuario = fila.Retirar();

            MessageBox.Show($"{usuario} saiu da fila.");
            MessageBox.Show($"Tempo de Espera: {usuario.Espera} minutos.");

            dgvUsuarios.Rows.RemoveAt(0);
            LimparCampos();

            btnInserir.Enabled = true;
            btnRemover.Enabled = false;
        }

        private void AtualizaPosicoes(object sender, EventArgs e)
        {
            MessageBox.Show(fila.ToString());
        }
    }
}
