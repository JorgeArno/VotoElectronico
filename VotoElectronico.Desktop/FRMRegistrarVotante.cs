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
    public partial class FRMRegistrarVotante : Form
    {
        public FRMRegistrarVotante()
        {
            InitializeComponent();
        }

        VotantesServices myVotantesServices = new VotantesServices();
        ValidationServices myValidationServices = new ValidationServices();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            myVotantesServices.agregarVotante(Convert.ToInt64(txtCedula.Text), txtFirstName.Text, txtLastName.Text, Convert.ToSByte(txtAge.Text));
        }

        private void btnRestablecerFormulario_Click(object sender, EventArgs e)
        {
            myValidationServices.restablecerFrmRegistroVotantes(txtFirstName, txtLastName, txtCedula, txtAge);
        }
    }
}
