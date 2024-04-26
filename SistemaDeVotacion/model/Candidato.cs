using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacion.model
{
    internal class Candidato
    {
        int id;
        string nombre;
        string apellido;
        int edad;
        int idDepartamento;
        Partido partido;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        //public int IdPartido { get => idPartido; set => idPartido = value; }
        public int Edad { get => edad; set => edad = value; }

        public string NombreCompletoYPartido
        {
            get { return $"{Nombre} {Apellido} {Partido.Nombre}"; }
        }

        internal Partido Partido { get => partido; set => partido = value; }
    }
}
