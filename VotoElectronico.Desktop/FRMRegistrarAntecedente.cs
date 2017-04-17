﻿using System;
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
    public partial class FRMRegistrarAntecedente : Form
    {
        public FRMRegistrarAntecedente()
        {
            InitializeComponent();
        }

        AntecedentesServices myAntecedentesServices = new AntecedentesServices();
        ValidationServices myValidationServices = new ValidationServices();

        private void btnRegistrarAntecedente_Click(object sender, EventArgs e)
        {
            try
            {
                myAntecedentesServices.addCrime(Convert.ToInt64(txtCedula.Text), txtFirstName.Text, txtLastName.Text, txtCrime.Text);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestablecerFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                myValidationServices.restablecerFrmRegistro(txtCedula, txtFirstName, txtLastName, txtCrime);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
