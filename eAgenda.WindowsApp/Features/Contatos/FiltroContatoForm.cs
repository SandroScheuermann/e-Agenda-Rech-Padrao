using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class FiltroContatoForm : Form
    {
        public FiltroContatoForm()
        {
            InitializeComponent();
        }
        public FiltroContatoEnum TipoFiltro
        {
            get
            {
                if (rdbPorEmpresa.Checked)
                    return FiltroContatoEnum.PorEmpresa;

                else if (rdbPorCargo.Checked)
                    return FiltroContatoEnum.PorCargo;

                else
                    return FiltroContatoEnum.SemAgrupamento;
            }
        }
    }
}
