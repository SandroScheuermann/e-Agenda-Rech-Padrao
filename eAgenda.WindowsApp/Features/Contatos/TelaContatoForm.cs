using eAgenda.Dominio.ContatoModule;
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

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get { return contato; }

            set
            {
                contato = value;

                txtId.Text = contato.Id.ToString();
                txtNome.Text = contato.Nome;
                txtCargo.Text = contato.Cargo;
                txtEmail.Text = contato.Email;
                txtEmpresa.Text = contato.Empresa;
                txtTelefone.Text = contato.Telefone;
            }
        }
        private void TelaContatoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string email = txtEmail.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;

            contato = new Contato(nome, email, telefone, empresa, cargo);

            string resultadoValidacao = contato.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
