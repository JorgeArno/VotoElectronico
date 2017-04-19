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
        AntecedentesServices myAntecedentesServices = new AntecedentesServices();
        ValidationServices myValidationServices = new ValidationServices();

        private void btnRegistrarVotante_Click(object sender, EventArgs e)
        {
            FRMRegistrarVotante registrarVotante = new FRMRegistrarVotante();
            registrarVotante.Show();
        }

        private void btnBuscarVotante_Click(object sender, EventArgs e)
        {
            try
            {
                myVotantesServices.buscarVotantes(Convert.ToInt64(txtBuscarVotante.Text));
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarVotante_Click(object sender, EventArgs e)
        {
          FRMActualizarVotante myFrmActualizarVotante = new FRMActualizarVotante(int.Parse(dgvResults.CurrentCell.Value.ToString()));
            myFrmActualizarVotante.Show();
        }

        private void btnValidarVotante_Click(object sender, EventArgs e)
        {            

            if (myValidationServices.derechoAVotar(Convert.ToInt64(dgvResults.CurrentCell.Value.ToString()))) 
            {
                DialogResult autorizarVoto;

                autorizarVoto = MessageBox.Show("Este ciudadano tiene derecho al voto." + Environment.NewLine + "Desea realizar su voto ahora?", "Ciudadano Puede Votar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(autorizarVoto == DialogResult.Yes)
                {
                    FRMRealizarVoto realizarVoto = new FRMRealizarVoto();
                    realizarVoto.Show();
                }
            }
            else
            {
                MessageBox.Show("No puede votar", "Votante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResultadoVotaciones_Click(object sender, EventArgs e)
        {
            FRMResultadosVotacion resultadoElecciones = new FRMResultadosVotacion();
            resultadoElecciones.Show();
        }

        private void btnRegistrarAntecedentes_Click(object sender, EventArgs e)
        {
            try
            {
                FRMRegistrarActualizarAntecedente registroAntecedentes = new FRMRegistrarActualizarAntecedente("registrar", 0);
                registroAntecedentes.Show();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVotoEletronico_Load(object sender, EventArgs e)
        {
            dgvResults.DataSource = myVotantesServices.obtenerVotantes();
        }

        private void btnEliminarAntecedente_Click(object sender, EventArgs e)
        {
            try
            {
                myAntecedentesServices.deleteCrime(int.Parse(dgvResults.CurrentCell.Value.ToString()));
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Debe seleccionar el ID, del crimen a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAntecedente_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResults.DataSource = myAntecedentesServices.searchCrime(Convert.ToInt64(txtBuscarAntecedente.Text));
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Verificar si estan los 11 digitos de la cedula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
