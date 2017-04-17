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

        public void agregarVotante(Int64 cedula, string firstName, string lastName, sbyte age)
        {
            if(cedula != 0 &  firstName != string.Empty & lastName != string.Empty & age != 0)
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
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Informacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        public List<Votante> obtenerVotantes()
        {
            return context.Votantes.ToList();
        }

        public List<Votante> buscarVotantes(string firstName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    return context.Votantes.ToList();
                }
                else
                {
                    return context.Votantes.Where(voto => voto.firstName.Contains(firstName)).ToList();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void actualizarVotante(int ID, Int64 cedula, string firstName, string lastName, sbyte age)
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
            var listaVotantes = from x in context.Votantes
                                where x.ID == ID
                                select x;

            foreach(Votante eliminarVotante in listaVotantes)
            {
                context.Votantes.Remove(eliminarVotante);
            }
            context.SaveChanges();
        }
    }
}
