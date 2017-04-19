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
    public partial class FRMRealizarVoto : Form
    {
        public FRMRealizarVoto()
        {
            InitializeComponent();
        }

        VotosServices myVotosServices = new VotosServices();

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbtnPrimerCandidato.Checked == true)
            {
                myVotosServices.addVoto("Primer Candidato");
            }
            else if(rbtnSegundoCandidato.Checked == true)
            {
                myVotosServices.addVoto("Segundo Candidato");
            }
            else if(rbtnTercerCandidato.Checked == true)
            {
                myVotosServices.addVoto("Tercer Candidato");
            }
            else if(rbtnCuartoCandidato.Checked == true)
            {
                myVotosServices.addVoto("Cuarto Candidato");
            }
            else if(rbtnQuintoCandidato.Checked == true)
            {
                myVotosServices.addVoto("Quinto Candidato");
            }
            
        }
    }
}
