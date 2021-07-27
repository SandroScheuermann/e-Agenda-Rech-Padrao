using eAgenda.Controladores.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public class OperacoesContato : ICadastravel
    {

        private readonly ControladorContato controlador = null;
        private readonly TabelaContatoControl tabelaContatos = null;

        public OperacoesContato(ControladorContato controlador)
        {
            this.controlador = controlador;
            tabelaContatos = new TabelaContatoControl();
        }
        public void InserirNovoRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Tarefa: [{tela.Contato.Nome}] inserido com sucesso");
            }
        }
        public void EditarRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder editar!", "Edição de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            TelaContatoForm tela = new TelaContatoForm();

            tela.Contato = contatoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] editado com sucesso");
            }
        }
        public void ExcluirRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder excluir!", "Exclusão de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o contato: [{contatoSelecionado.Nome}] ?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{contatoSelecionado.Nome}] removido com sucesso");
            }
        }
        public UserControl ObterTabela()
        {
            List<Contato> contatos = controlador.SelecionarTodos();

            tabelaContatos.AtualizarRegistros(contatos);

            return tabelaContatos;
        }
        public void FiltrarRegistros()
        {
            FiltroContatoForm telaAgrupamento = new FiltroContatoForm();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {
                switch (telaAgrupamento.TipoFiltro)
                {
                    case FiltroContatoEnum.PorCargo:
                        tabelaContatos.AgruparContatosPor("Cargo");
                        break;

                    case FiltroContatoEnum.PorEmpresa:
                        tabelaContatos.AgruparContatosPor("Empresa");
                        break;

                    case FiltroContatoEnum.SemAgrupamento:
                        tabelaContatos.DesagruparContatos();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
