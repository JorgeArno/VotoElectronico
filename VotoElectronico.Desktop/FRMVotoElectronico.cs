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
    public partial class frmVotoEletronico : Form
    {
        public frmVotoEletronico()
        {
            InitializeComponent();
        }
        

        VotantesServices myVotantesServices = new VotantesServices();

        private void btnRegistrarVotante_Click(object sender, EventArgs e)
        {
            FRMRegistrarVotante registrarVotante = new FRMRegistrarVotante();
            registrarVotante.Show();
        }

        private void btnBuscarVotante_Click(object sender, EventArgs e)
        {
            myVotantesServices.buscarVotantes(Convert.ToInt64(txtBuscarVotante.Text));
        }

        private void btnActualizarVotante_Click(object sender, EventArgs e)
        {
          FRMActualizarVotante myFrmActualizarVotante = new FRMActualizarVotante(int.Parse(dgvResults.CurrentCell.Value.ToString()));
            myFrmActualizarVotante.Show();
        }

        private void btnValidarVotante_Click(object sender, EventArgs e)
        {
            bool age, crime;
            age = myValidationServices.ageValidation(Convert.ToInt64(txtBuscarVotante.Text));
            crime = myValidationServices.crimeValidation(Convert.ToInt64(txtBuscarVotante.Text));

            if (age == true & crime == true) 
            {

                /*Llamar formulario ejercer voto*/
            }
            else
            {
                MessageBox.Show("No puede votar", "Votante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
