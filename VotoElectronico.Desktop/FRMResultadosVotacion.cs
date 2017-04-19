using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace VotoElectronico.Desktop
{
    public partial class FRMResultadosVotacion : Form
    {
        public FRMResultadosVotacion()
        {
            InitializeComponent();
        }

        VotosServices myVotoServices = new VotosServices();

        private void FRMResultadosVotacion_Load(object sender, EventArgs e)
        {
            myVotoServices.countVotos(dgvResultadoVotaciones);
        }
    }
}
