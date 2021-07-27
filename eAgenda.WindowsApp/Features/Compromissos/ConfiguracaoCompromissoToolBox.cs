using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WindowsApp.Shared;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    class ConfiguracaoCompromissoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro de Compromissos"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Compromisso"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Compromisso existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Compromisso existente"; }
        }
        public string ToolTipFiltro
        {
            get { return "Filtrar Compromissos"; }
        }
    }
}
