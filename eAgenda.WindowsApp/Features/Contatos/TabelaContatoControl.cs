using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WindowsApp.Shared;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TabelaContatoControl : UserControl
    {
        Subro.Controls.DataGridViewGrouper contatoGrouper = new Subro.Controls.DataGridViewGrouper();
        public TabelaContatoControl()
        {
            InitializeComponent();
            gridContatos.ConfigurarGridZebrado();
            gridContatos.ConfigurarGridSomenteLeitura();
            gridContatos.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo"}
            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridContatos.SelecionarId<int>();
        }
        public void AtualizarRegistros(List<Contato> contatos)
        {
            CarregarTabela(contatos);
        }
        private void CarregarTabela(List<Contato> contatos)
        {
            //gridContatos.Rows.Clear();

            //foreach (Contato contato in contatos)
            //{
            //    gridContatos.Rows.Add(contato.Id, contato.Nome, contato.Email,
            //        contato.Telefone, contato.Empresa, contato.Cargo);
            //}

            gridContatos.DataSource = contatos;

            contatoGrouper = new Subro.Controls.DataGridViewGrouper(gridContatos);
        }
        public void DesagruparContatos()
        {
            var campos = new string[] { "Cargo", "Empresa" };

            contatoGrouper.RemoveGrouping();
            gridContatos.RowHeadersVisible = true;

            foreach (var campo in campos)
                foreach (DataGridViewColumn item in gridContatos.Columns)
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
        }
        public void AgruparContatosPor(string campo)
        {
            contatoGrouper.RemoveGrouping();
            contatoGrouper.SetGroupOn(campo);
            contatoGrouper.Options.ShowGroupName = false;
            contatoGrouper.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in gridContatos.Columns)
                if (item.DataPropertyName == campo)
                    item.Visible = false;

            gridContatos.RowHeadersVisible = false;
            gridContatos.ClearSelection();
        }

    }
}
