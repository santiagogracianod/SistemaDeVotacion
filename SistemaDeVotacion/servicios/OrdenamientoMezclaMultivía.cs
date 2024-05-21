using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacion.servicios
{
    internal class OrdenamientoMezclaMultivía
    {
        public static void OrdenarMultiVias(List<KeyValuePair<string, int>> lista)
        {
            // Determinar el número de vías (segmentos) para dividir la lista
            int numeroVias = ObtenerNumeroVias(lista.Count);

            // Dividir la lista en segmentos
            List<List<KeyValuePair<string, int>>> segmentos = DividirEnSegmentos(lista, numeroVias);

            // Ordenar cada segmento individualmente
            foreach (var segmento in segmentos)
            {
                MergeSort(segmento);
            }

            // Fusionar los segmentos ordenados en una sola lista
            lista.Clear();
            lista.AddRange(MezclarSegmentos(segmentos));
        }

        private static List<List<KeyValuePair<string, int>>> DividirEnSegmentos(List<KeyValuePair<string, int>> lista, int numeroVias)
        {
            List<List<KeyValuePair<string, int>>> segmentos = new List<List<KeyValuePair<string, int>>>();

            int tamañoSegmento = (int)Math.Ceiling((double)lista.Count / numeroVias);

            for (int i = 0; i < lista.Count; i += tamañoSegmento)
            {
                List<KeyValuePair<string, int>> segmento = lista.GetRange(i, Math.Min(tamañoSegmento, lista.Count - i));
                segmentos.Add(segmento);
            }

            return segmentos;
        }

        private static List<KeyValuePair<string, int>> MezclarSegmentos(List<List<KeyValuePair<string, int>>> segmentos)
        {
            List<KeyValuePair<string, int>> resultado = new List<KeyValuePair<string, int>>();

            // Recorrer cada segmento y fusionarlo con el resultado
            foreach (var segmento in segmentos)
            {
                resultado = Mezclar(resultado, segmento);
            }

            return resultado;
        }

        private static List<KeyValuePair<string, int>> Mezclar(List<KeyValuePair<string, int>> lista1, List<KeyValuePair<string, int>> lista2)
        {
            List<KeyValuePair<string, int>> resultado = new List<KeyValuePair<string, int>>();
            int i = 0, j = 0;

            // Fusionar las dos listas ordenadas en una sola lista ordenada
            while (i < lista1.Count && j < lista2.Count)
            {
                if (lista1[i].Value >= lista2[j].Value)
                {
                    resultado.Add(lista1[i]);
                    i++;
                }
                else
                {
                    resultado.Add(lista2[j]);
                    j++;
                }
            }

            // Agregar los elementos restantes de lista1, si los hay
            while (i < lista1.Count)
            {
                resultado.Add(lista1[i]);
                i++;
            }

            // Agregar los elementos restantes de lista2, si los hay
            while (j < lista2.Count)
            {
                resultado.Add(lista2[j]);
                j++;
            }

            return resultado;
        }

        private static int ObtenerNumeroVias(int tamañoLista)
        {
            // Definir el número máximo de vías (puedes ajustar este valor según tus necesidades)
            int numeroMaximoVias = 5;

            // Calcular el número de vías en función del tamaño de la lista
            int numeroVias = Math.Min(numeroMaximoVias, tamañoLista);

            return numeroVias;
        }

        // Implementación del algoritmo de ordenamiento por mezcla (Merge Sort)
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
                // Comparar de mayor a menor (cambiar el signo de comparación)
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

            // Agregar los elementos restantes de la lista izquierda
            while (i < izquierda.Count)
            {
                lista[k] = izquierda[i];
                i++;
                k++;
            }

            // Agregar los elementos restantes de la lista derecha
            while (j < derecha.Count)
            {
                lista[k] = derecha[j];
                j++;
                k++;
            }
        }

    }


}
