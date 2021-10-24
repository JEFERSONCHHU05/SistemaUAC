using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
        {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string correo;
        private string celular;
        private string fechaNacimiento;
        private string cargo;
        private string gradoAcademico;
        private string fechaIngresoDocente;
        // Propiedades para los atriutos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string FechaNaciemineto
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string GradoAcademico
        {
            get { return gradoAcademico; }
            set { gradoAcademico = value; }
        }
        public string FechaIngresoDocente
        {
            get { return fechaIngresoDocente; }
            set { fechaIngresoDocente = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Ensenar()
        {
            return "Este metodo enseñar recien será implementado";
        }
        public string Motivar()
        {
            return "Este metodo motivar recien seá implementado";
        }
        public string Evaluar()
        {
            return "Este metodo evaluar recien será implementado";
        }
        public string Aconsejar()
        {
            return "Este metodo aconsejar recien será implementado";
        }
        public string SubirNotas()
        {
            return "Este metodo subirNotas recien será implementado";
        }
    }
}

