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
    public class VotosServices
    {
        ContextDB context = new ContextDB();
        Voto myVoto = new Voto();

        public void addVoto(string voto)
        {
            myVoto.votosAlmacenados = voto;
            context.Votos.Add(myVoto);
            context.SaveChanges();
        }

        /* **OJO** SE DEBE OPTIMIZAR ESTE METODO 
        public List<Voto> ordenCandidatos()
        {
            var listVotos = from x in context.Votos
                             group x by x.votosAlmacenados into conteoVotos
                             select conteoVotos;

            List<Voto> votosReturn = null;

            foreach(List<Voto> myVotos in listVotos)
            {

                votosReturn = myVotos.ToList();
            }

            return votosReturn.ToList();                
           
        }

        */

        public void countVotos(DataGridView resultadoElecciones)
        {


            string[] candidtatos = new string[5]{"Primer Candidato","Segundo Candidato","Tercer Candidato","Cuarto Candidato","Quinto Candidato"};
            int[] votosRealizados = new int[5];


            for (int i = 1; i < 5; i++)
            {
                votosRealizados[i] = (from x in context.Votos
                                      where x.votosAlmacenados.Contains(candidtatos[i])
                                      select x).Count();
            }

            
            for (int i = 1; i < 5; i++)
            {
                resultadoElecciones.Rows.Add(candidtatos[i], votosRealizados[i]);
            }
           



            
        }
    }
}
