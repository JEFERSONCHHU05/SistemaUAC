using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Declaracion de atributos
        private string nombres;
        private string creditos;
        private string especialidad;
        private string horario;
        private string codigo;
        private string tiempo;
        // Propiedades para los atriutos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Contar()
        {
            return "Este metodo contar recien será implementado";
        }
        public string Ordenar()
        {
            return "Este metodo ordenar recien será implementado";
        }
        public string Examinar()
        {
            return "Este metodo examinar recien será implementado";
        }
        public string Aprender()
        {
            return "Este metodo aprender recien será implementado";
        }
        public string Indagar()
        {
            return "Este metodo indagar recien será implementado";
        }
        public string Especializar()
        {
            return "Este metodo especializar recien será implementado";
        }
    }
}
