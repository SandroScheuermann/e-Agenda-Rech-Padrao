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
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        Compromisso compromisso;
        public TelaCompromissoForm()
        {
            InitializeComponent();
            CarregarContatos();
        }
        private void CarregarContatos()
        {
            cbb_Contato.DataSource = controladorContato.SelecionarTodos();
        }
        public Compromisso Compromisso
        {
            get { return compromisso; }

            set
            {
                compromisso = value;

                txtId.Text = compromisso.Id.ToString();
                txt_Assunto.Text = compromisso.Assunto;
                txt_Link.Text = compromisso.Link;
                txt_Local.Text = compromisso.Local;
                mtxt_Data.Text = compromisso.Data.ToString("d");
                mtxt_HoraInicio.Text = compromisso.HoraInicio.ToString();
                mtxt_HoraFim.Text = compromisso.HoraTermino.ToString();

                if(compromisso.Contato == null)
                    cbb_Contato.SelectedIndex = default;
                else
                    cbb_Contato.SelectedItem = compromisso.Contato;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txt_Assunto.Text;
            string link = txt_Link.Text;
            string local = txt_Local.Text;
            DateTime data = Convert.ToDateTime(mtxt_Data.Text);
            TimeSpan horaInicio = TimeSpan.Parse(mtxt_HoraInicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(mtxt_HoraFim.Text);

            Contato contato = null;

            if (!chb_SemContato.Checked)
                contato = (Contato)cbb_Contato.SelectedItem;


            compromisso = new Compromisso(assunto,local,link,data,horaInicio,horaFim,contato);

            string resultadoValidacao = compromisso.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
        private void TelaTarefaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
        private void chb_SemContato_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_SemContato.Checked)
                cbb_Contato.Enabled = false;
            else
                cbb_Contato.Enabled = true;
        }
    }
}
