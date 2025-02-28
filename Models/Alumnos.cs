using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MVC.Models
{
    public class Alumnos : BaseModel 
    {
        #region Propiedades
        [Key ]
        public int AlumnoId { get; set; }
        [NotNull]
        [Required(ErrorMessage= "Nombre es requerido")]
        public string  Nombres { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Apellidos es requerido")]
        public string Apellidos { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Edad es requerido")]
        public int Edad { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Carnet es requerido")]
        public string Carnet { get; set;}
        [Required(ErrorMessage = "Cantidad de materias es requerido")]
        public int CantidadMaterias { get; set; }
        [Required(ErrorMessage = "Ciclo es requerido")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Fecha de nacimiento es requerido")]
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        public string NombreCompleto { get; set; }
        #endregion Propiedades

        #region Constructor
        public Alumnos() 
        {
            FechaNacimiento = DateTime.Now;
            IsActive = true;
            Created = DateTime.Now;
            CreatedBy = "ADMIN";
        }
        public Alumnos(string nombres, int edad, string apellidos, DateTime fechaNacimiento)
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