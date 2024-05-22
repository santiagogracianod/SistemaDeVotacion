using SistemaDeVotacion.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacion.servicios
{
    internal class OrdenemientoCountingSort
    {
        public static List<Candidato> OrdenarPorVotos(List<Candidato> candidatos)
        {
         
            int maxVotos = candidatos.Max(c => c.Votos);

          
            int[] conteo = new int[maxVotos + 1];

        
            foreach (Candidato candidato in candidatos)
            {
                conteo[candidato.Votos]++;
            }

         
            for (int i = 1; i <= maxVotos; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            Candidato[] candidatosOrdenados = new Candidato[candidatos.Count];

           
            foreach (Candidato candidato in candidatos)
            {
                int pos = conteo[candidato.Votos] - 1;
                candidatosOrdenados[pos] = candidato;
                conteo[candidato.Votos]--;
            }

            return candidatosOrdenados.Reverse().ToList();
        }
    }
}
