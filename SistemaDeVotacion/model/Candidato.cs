using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacion.model
{
    public class Candidato
    {
        int id;
        string nombre;
        string apellido;
        int edad;
        int idDepartamento;
        Partido partido;
        int votos;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Votos { get => votos; set => votos = value; }


        public string NombreCompletoYPartido
        {
            get { return $"{id} {Nombre} {Apellido} {Partido.Nombre}"; }
        }

        public Partido Partido { get => partido; set => partido = value; }
    }
}
