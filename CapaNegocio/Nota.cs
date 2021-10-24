using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Nota
    {
        //Declaracion de atributos
        private string asignatura;
        private string codigo;
        private string status;
        private string inspeccionar;
        private string valor;
        public string Correo;
        public string Estatus;

        // Propiedades para los atriutos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Inspeccionar
        {
            get { return inspeccionar; }
            set { inspeccionar = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Posicionar()
        {
            return "Este metodo posicionar recien será implementado";
        }
        public string Calificar()
        {
            return "Este metodo calificar recien será implementado";
        }
        public string Ranquear()
        {
            return "Este metodo ranquear recien será implementado";
        }
        public string Ordenar()
        {
            return "Este metodo ordenar recien será implementado";
        }
        public string Promediar()
        {
            return "Este metodo promediar recien será implementado";
        }
        public string Indicar()
        {
            return "Este metodo indicar recien será implementado";
        }
    }
}
