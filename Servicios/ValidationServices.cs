﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotoElectronico;
using Entidades;
using System.Windows.Forms;

namespace Servicios
{
    public class ValidationServices
    {
        ContextDB context = new ContextDB();

        public bool crimeValidation(Int64 cedula)
        {
            bool crime = false;

            try
            {               

                var listCrime = from x in context.Antecedentes
                                where x.cedula == cedula
                                select x;

                foreach (Antecedente myCrime in listCrime)
                {
                    if (myCrime.cedula == cedula)
                    {
                        crime = true;
                    }
                }

                return crime;
            }        
            catch(Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Realizar consulta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return crime;
            }

             
        }

        public bool ageValidation(Int64 cedula)
        {
            bool voto = false;

            try
            {
                var listVoto = from x in context.Votantes
                               where x.cedula == cedula
                               select x;


                foreach (Votante myVotante in listVoto)
                {
                    if (myVotante.age >= 18)
                    {
                        voto = true;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Realizar consulta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return voto;
            
        }

        public bool derechoAVotar(Int64 cedula)
        {
            bool crime = false;
            bool age = false;

            crime = crimeValidation(cedula);
            age = ageValidation(cedula);

            if(crime == true & age == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void restablecerFrmRegistro(TextBox firstName, TextBox lastName, TextBox cedula, TextBox datoARegitrar)
        {
            firstName.Clear();
            lastName.Clear();
            cedula.Clear();
            datoARegitrar.Clear();
        }

        public bool votanteDuplicado(Int64 cedula)
        {
            bool duplicado = false;

            var listVotantes = from x in context.Votantes
                               where x.cedula == cedula
                               select x;

            foreach(Votante myVotante in listVotantes)
            {
                if (myVotante.cedula == cedula)
                {
                    duplicado = true;
                }
            }

            return duplicado;
        }

        public void frmRegistrarOActualizarAntecedentes(string elegirFormulario, Button registrar, Button actualizar,Button restablecer)
        {
            if (elegirFormulario.Equals("registrar"))
            {
                registrar.Visible = true;
                actualizar.Visible = false;
                restablecer.Visible = true;
            }
            else if (elegirFormulario.Equals("actualizar"))
            {
                registrar.Visible = false;
                actualizar.Visible = true;
                restablecer.Visible = false;
            }
        }
       
    }
}
