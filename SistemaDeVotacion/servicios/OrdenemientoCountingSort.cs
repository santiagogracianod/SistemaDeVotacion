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
            // Encontrar el número máximo de votos
            int maxVotos = candidatos.Max(c => c.Votos);

            // Crear un array de conteo para contar la cantidad de candidatos con cada cantidad de votos
            int[] conteo = new int[maxVotos + 1];

            // Contar la cantidad de candidatos con cada cantidad de votos
            foreach (Candidato candidato in candidatos)
            {
                conteo[candidato.Votos]++;
            }

            // Modificar el array de conteo para que cada posición indique la posición de inicio de los candidatos con esa cantidad de votos
            for (int i = 1; i <= maxVotos; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            // Crear un array auxiliar para almacenar los candidatos ordenados temporalmente
            Candidato[] candidatosOrdenados = new Candidato[candidatos.Count];

            // Ordenar los candidatos en el array auxiliar
            foreach (Candidato candidato in candidatos)
            {
                int pos = conteo[candidato.Votos] - 1;
                candidatosOrdenados[pos] = candidato;
                conteo[candidato.Votos]--;
            }

            // Convertir el array auxiliar a una lista y devolverla en orden inverso
            return candidatosOrdenados.Reverse().ToList();
        }
    }
}
