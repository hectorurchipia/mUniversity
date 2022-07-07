using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monster_university.Models.Clases
{
    public class Carrera  // : Entidad  esto lo hizo RW para lo de las claves de 128b
    {
        // public Guid Id { get; set; }
        //public string CodCarrera { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
       

        public Carrera( int codigo, string nombre)
        {
            //Id = Guid.NewGuid();
            Id = codigo;
            Nombre = nombre;

        }
    }

    public class Persona  
    {
        
        public int  Id { get; set; }
        public string Nombre { get; set; }
        public int Rol { get; set; }
        public int IdCarrera { get; set; }

        public Persona(int idPersona, string nombre, int nRole, int codCarrera)
        {
            Id = idPersona;
            Nombre = nombre;
            Rol = nRole;
            IdCarrera = codCarrera;
        }
       
    }

    public class Materia
    {
        //public Guid Id { get; set; }
        public int Id { get; set; }
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public int IdSemestre { get; set; }
        public int IdCorrelativa1 { get; set; }
        public int IdCorrelativa2 { get; set; }

        public Materia( int idMateria, int  codigoCarrera, int nroSemestre, int idCorrelativa1 , int idCorrelativa2)
        {
            //Id = Guid.NewGuid();
            Id = idMateria;
            IdCarrera = codigoCarrera;
            IdSemestre = nroSemestre;
            IdCorrelativa1 = idCorrelativa1;
            IdCorrelativa2 = idCorrelativa2;
        }
    }

    public class Historial 
    {
        public Guid Id { get; set; }
        public int IdPersona { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public DateTime FechaExamen { get; set; }
        public float Nota { get; set; }

        public Historial(int idPersona, int codigoCarrera, int idMateria, DateTime fechaExamen, float nota)
        {
            Id = Guid.NewGuid();
            IdPersona = idPersona;
            IdCarrera = codigoCarrera;
            IdMateria = idMateria;
            FechaExamen = fechaExamen;
            Nota = nota;

        }
    }





}