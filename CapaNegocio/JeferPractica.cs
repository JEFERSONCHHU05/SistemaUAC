using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JeferPractica
    {
        //Declaracion de atributos
        private string nombres;
        private string creditos;
        private string especialidad;
        private string dni;
        private string correo;
        private string celular;
        public string Apellidos;

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
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
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
        // Declarancion de metodos u operaciones 
        public string Supervisar()
        {
            return "Este metodo supervisar recien será implementado";
        }
        public string Instruir()
        {
            return "Este metodo instruir recien será implementado";
        }
        public string Evaluar()
        {
            return "Este metodo evaluar recien será implementado";
        }
        public string Motivar()
        {
            return "Este metodo motivar recien será implementado";
        }
        public string Exponer()
        {
            return "Este metodo exponer recien será implementado";
        }
        public string Criticar()
        {
            return "Este metodo criticar recien será implementado";
        }
    }
}
