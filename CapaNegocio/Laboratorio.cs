using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //Declaracion de atributos
        private string nombres;
        private string creditos;
        private string horario;
        private string lugar;
        private string especialidad;
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
        public string Horarios
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Analizar()
        {
            return "Este metodo analizar recien será implementado";
        }
        public string Observar()
        {
            return "Este metodo observar recien será implementado";
        }
        public string Investigar()
        {
            return "Este metodo investigar recien será implementado";
        }
        public string Experimentar()
        {
            return "Este metodo experimentar recien será implementado";
        }
        public string Calcular()
        {
            return "Este metodo calcular recien será implementado";
        }
        public string Verificar()
        {
            return "Este metodo verificar recien será implementado";
        }
    }
}
