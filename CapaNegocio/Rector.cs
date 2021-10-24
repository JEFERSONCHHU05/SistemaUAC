using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Declaracion de atributos
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string celular;
        private string dni;
        private string correo;
        private string facultad;
        // Propiedades para los atriutos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
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
        public string Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Liderar()
        { 
            return "Este metodo liderar recien será implementado";
        }
        public string Representar()
        {
            return "Este metodo representar recien será implementado";
        }
        public string Impulsar()
        {
            return "Este metodo impulsar recien será implementado";
        }
        public string Supervisar()
        {
            return "Este metodo supervisar recien será implementado";
        }
        public string Orientar()
        {
            return "Este metodo orientar recien será implementado";
        }
        public string Evaluar()
        {
            return "Este metodo evaluar recien será implementado";
        }
        public string Reportar()
        {
            return "este metodo reportar recien será implementado";
        }
    }
}
