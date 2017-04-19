using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using VotoElectronico;
using System.Windows.Forms;
using System.Data.Entity;

namespace Servicios
{
    public class VotantesServices
    {
        ContextDB context = new ContextDB();
        ValidationServices myValidationServices = new ValidationServices();

        public void agregarVotante(Int64 cedula, string firstName, string lastName, sbyte age)
        {
            try
            {
                bool duplicidad = myValidationServices.votanteDuplicado(Convert.ToInt64(cedula));

                if (duplicidad == true)
                {
                    MessageBox.Show("Este votante ya esta registrado", "Votante Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cedula > 99999999 & cedula < 99999999999 & firstName != string.Empty & lastName != string.Empty & age != 0)
                    {
                        try
                        {
                            Votante nuevoVotante = new Votante();

                            nuevoVotante.cedula = cedula;
                            nuevoVotante.firstName = firstName;
                            nuevoVotante.lastName = lastName;
                            nuevoVotante.age = age;
                            context.Votantes.Add(nuevoVotante);
                            context.SaveChanges();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message + Environment.NewLine + "Error al agregar votante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos deben estar llenos.", "Informacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Error en los datos suministrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public List<Votante> obtenerVotantes()
        {
            try
            {
                return context.Votantes.ToList();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Votante> buscarVotantes(Int64 cedula)
        {
            if(cedula > 9999999999 && cedula <= 99999999999)
            {
                try
                {                    
                     return context.Votantes.Where(votante => votante.cedula == cedula).ToList();                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Cedula debe ser de 11 digitos.", "Verificar Cedula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            
        }

        public void loadVotantes(int id, TextBox firstName, TextBox lastName, TextBox cedula, TextBox age)
        {
            try
            {
                var listVotantes = from x in context.Votantes
                                   where x.ID == id
                                   select x;

                foreach (Votante myVotante in listVotantes)
                {
                    firstName.Text = myVotante.firstName;
                    lastName.Text = myVotante.lastName;
                    cedula.Text = Convert.ToString(myVotante.cedula);
                    age.Text = Convert.ToString(myVotante.age);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void actualizarVotante(int ID, Int64 cedula, string firstName, string lastName, int age)
        {
            try
            {
                var ListaVotantes = from x in context.Votantes
                                      where x.ID == ID
                                      select x;

                foreach(Votante nuevoVotante in ListaVotantes)
                {
                    nuevoVotante.cedula = cedula;
                    nuevoVotante.firstName = firstName;
                    nuevoVotante.lastName = lastName;
                    nuevoVotante.age = age;
                }
                context.SaveChanges();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarVotante(int ID)
        {
            DialogResult delete;

            delete = MessageBox.Show("Realmente desea eliminar este votante", "Eliminar Votante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(delete == DialogResult.Yes)
            {
                try
                {
                    var listaVotantes = from x in context.Votantes
                                        where x.ID == ID
                                        select x;

                    foreach (Votante eliminarVotante in listaVotantes)
                    {
                        context.Votantes.Remove(eliminarVotante);
                    }
                    context.SaveChanges();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
