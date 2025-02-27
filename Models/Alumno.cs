using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MVC.Models
{
    public class Alumno
    {
        #region Propiedades
        [Key ]
        public int AlumnoId { get; set; }
        [NotNull]
        public string  Nombres { get; set; }
        [NotNull]
        public string Apellidos { get; set; }
        [NotNull]
        public int Edad { get; set; }
        [NotNull]
        public string Carnet { get; set;}
        public int CantidadMaterias { get; set; }
        public int Ciclo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        public string NombreCompleto { get; set; }
        #endregion Propiedades

        #region Constructor
        public Alumno(string nombres, int edad, string apellidos, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Edad = edad;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            NombreCompleto = $"{ Nombres} { Apellidos}";
        }
        #endregion Constructor
        #region Funciones

        public bool  EsMayorDeEdad()
        {
            return Edad > 18;
        }
        #endregion Funciones
    }
}