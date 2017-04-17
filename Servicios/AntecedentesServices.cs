using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotoElectronico;
using Entidades;
using System.Windows.Forms;

namespace Servicios
{
    class AntecedentesServices
    {
        ContextDB context = new ContextDB();
        Antecedente newCrime = new Antecedente();

        public void addCrime(Int64 cedula, string firstName, string lastName, string crime)
        {
            if(cedula != 0 & firstName != string.Empty & lastName != string.Empty & crime != string.Empty)
            {
                try
                {
                    newCrime.cedula = cedula;
                    newCrime.firstName = firstName;
                    newCrime.lastName = lastName;
                    newCrime.crime = crime;
                    context.Antecedentes.Add(newCrime);
                    context.SaveChanges();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


          
        }

        public List<Antecedente> getCrime()
        {
            try
            {
                return context.Antecedentes.ToList();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Antecedente> searchCrime(Int64 cedula)
        {

            try
            {
                if (cedula.Equals(string.Empty))
                {
                    return context.Antecedentes.ToList();
                }
                else
                {
                    var listCrime = from x in context.Antecedentes
                                    where x.cedula == cedula
                                    select x;

                    return listCrime.ToList();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public void updateCrime(int id, Int64 cedula, string firstName, string lastName, string crime)
        {
            try
            {
                var listCrime = from x in context.Antecedentes
                                where x.ID == id
                                select x;

                foreach (Antecedente myCrime in listCrime)
                {
                    myCrime.cedula = cedula;
                    myCrime.firstName = firstName;
                    myCrime.lastName = lastName;
                    myCrime.crime = crime;
                }
                context.SaveChanges();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteCrime(int id)
        {

            DialogResult delete;

            delete = MessageBox.Show("Realmente desea eliminar este Antecedente?", "Eliminar Antecedente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (delete == DialogResult.Yes)
                {
                    var listCrime = from x in context.Antecedentes
                                    where x.ID == id
                                    select x;

                    foreach (Antecedente myCrime in listCrime)
                    {
                        context.Antecedentes.Remove(myCrime);
                    }
                    context.SaveChanges();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
