using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string celular;
        private string codigo;
        private string correo;
        private string semestreInicio;
        private string escuelaProfessional;
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
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string SemetreInicio
        {
            get { return semestreInicio; }
            set { semestreInicio = value; }
        }
        public string EscuelaProfessional
        {
            get { return escuelaProfessional; }
            set { escuelaProfessional = value; }
        }

        // Declarancion de metodos u operaciones 
        public string Matricular()
        {
            return "Este metodo matricular recien será implementado";
        }
        public string Estudiar()
        {
            return "Este metodo restudiar ecien será implementado";
        }
        public string Aprobar()
        {
            return "Este metodo aprobar recien será implementado";
        }
        public string Desaprobar()
        {
            return "Este metodo desaprobar recien será implementado";
        }
        public string Atender()
        {
            return "Este metodo atender recien será implementado";
        }
        public string RendirExamen()
        {
            return "Este metodo rendirExamen recien será implementado";
        }
        public string TrabajoEquipo()
        {
            return "Este metodo trabajoEquipo recien será implementado";
        }
    }
}
