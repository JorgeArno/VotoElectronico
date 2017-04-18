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
using VotoElectronico.Desktop;

namespace VotoElectronico.Desktop
{
    public partial class FRMActualizarVotante : Form
    {
        public FRMActualizarVotante()
        {
            InitializeComponent();
            myVotantesServices.loadVotantes(int.Parse(/* Falta id */, txtFirstName, txtLastName, txtCedula, txtAge));
        }

        ValidationServices myValidationServices = new ValidationServices();
        VotantesServices myVotantesServices = new VotantesServices();
        
        

        private void btnActualizarVotante_Click(object sender, EventArgs e)
        {
            myVotantesServices.actualizarVotante(Convert.ToSByte(/* Falta id */), Convert.ToInt64(txtCedula.Text), txtFirstName.Text, txtLastName.Text, Convert.ToSByte(txtAge.Text));
        }
    }
}
