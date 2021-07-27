using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class FiltroCompromissoForm : Form
    {
        DateTime de;
        DateTime para;


        public FiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public FiltroCompromissoEnum TipoFiltro
        {
            get
            {
                if (rdbEntre.Checked)
                {
                    de = pickerDe.Value;
                    para = pickerPara.Value;
                    return FiltroCompromissoEnum.CompromissosEntreDatas;
                }

                else if (rdbPassados.Checked)
                    return FiltroCompromissoEnum.CompromissosPassados;

                else
                    return FiltroCompromissoEnum.TodosCompromissos;
            }
        }
        public DateTime De { get => de;}
        public DateTime Para { get => para;}
    }
}
