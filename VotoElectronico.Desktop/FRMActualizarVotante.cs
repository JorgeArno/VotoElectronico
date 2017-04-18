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
        public int idVal { get; set; }

        public FRMActualizarVotante(int id)
        {
            InitializeComponent();
            idVal = id;
            myVotantesServices.loadVotantes(id, txtFirstName, txtLastName, txtCedula, txtAge);
        }

        VotantesServices myVotantesServices = new VotantesServices();
  
        private void btnActualizarVotante_Click(object sender, EventArgs e)
        {
            myVotantesServices.actualizarVotante(idVal, Convert.ToInt64(txtCedula.Text), txtFirstName.Text, txtLastName.Text, Convert.ToSByte(txtAge.Text));
        }
    }
}
