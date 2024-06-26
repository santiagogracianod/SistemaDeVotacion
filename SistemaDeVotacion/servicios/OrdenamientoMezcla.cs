﻿

namespace SistemaDeVotacion.servicios
{
    internal class OrdenamientoMezcla
    {
        public static Dictionary<string, int> votosPorDepartamento(Dictionary<string, int> votos)
        {
            List<KeyValuePair<string, int>> listaVotos = new List<KeyValuePair<string, int>>(votos);

            MergeSort(listaVotos);

            Dictionary<string, int> votosOrdenados = new Dictionary<string, int>();
            foreach (var kvp in listaVotos)
            {
                votosOrdenados.Add(kvp.Key, kvp.Value);
            }

            return votosOrdenados;
        }

        private static void MergeSort(List<KeyValuePair<string, int>> lista)
        {
            if (lista.Count <= 1)
                return;

            int medio = lista.Count / 2;
            List<KeyValuePair<string, int>> izquierda = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> derecha = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < medio; i++)
            {
                izquierda.Add(lista[i]);
            }
            for (int i = medio; i < lista.Count; i++)
            {
                derecha.Add(lista[i]);
            }

            MergeSort(izquierda);
            MergeSort(derecha);
            Merge(lista, izquierda, derecha);
        }

        private static void Merge(List<KeyValuePair<string, int>> lista, List<KeyValuePair<string, int>> izquierda, List<KeyValuePair<string, int>> derecha)
        {
            int i = 0, j = 0, k = 0;

            while (i < izquierda.Count && j < derecha.Count)
            {
                if (izquierda[i].Value >= derecha[j].Value)
                {
                    lista[k] = izquierda[i];
                    i++;
                }
                else
                {
                    lista[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Count)
            {
                lista[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Count)
            {
                lista[k] = derecha[j];
                j++;
                k++;
            }
        }

    }
}
