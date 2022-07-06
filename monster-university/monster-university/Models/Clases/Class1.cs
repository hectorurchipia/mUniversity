using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monster_university.Models.Clases
{
    public class Carrera  // : Entidad  esto lo hizo RW para lo de las claves de 128b
    {
        public string Cod_carrera { get; set; }
        public string Nombre { get; set; }

        public Carrera( string codigo, string nombre)
        {
            Cod_carrera = codigo;
            Nombre = nombre;
        }
    }

    public class Persona  
    {
        public int  id_persona { get; set; }
        public string Nombre { get; set; }
        public int role { get; set; }
        public string cod_carrera { get; set; }

        public Persona(int idPersona, string nombre, int nRole, string codCarrera)
        {
            id_persona = idPersona;
            Nombre = nombre;
            role = nRole;
            cod_carrera = codCarrera;
        }
       
    }

    public class Materia
    {
        public int id_materia { get; set; }
        public string cod_carrera { get; set; }
        public int id_semestre { get; set; }
        public int id_correlativa1 { get; set; }
        public int id_correlativa2 { get; set; }

        public Materia( int Id, string CodigoCarrera, int nroSemestre, int idCorrelativa1 , int idCorrelativa2)
        {
            id_materia = Id;
            cod_carrera = CodigoCarrera;
            id_semestre = nroSemestre;
            id_correlativa1 = idCorrelativa1;
            id_correlativa2 = idCorrelativa2;
        }
    }

    public class Historial 
    {
        public int id_persona { get; set; }
        public int id_materia { get; set; }
        public DateTime fecha_examen { get; set; }
        public float nota { get; set; }

        public Historial(int idPersona, int idMateria, DateTime fechaExamen, float Nota)
        {
            id_persona = idPersona;
            id_materia = idMateria;
            fecha_examen = fechaExamen;
            nota = Nota;

        }
    }





}