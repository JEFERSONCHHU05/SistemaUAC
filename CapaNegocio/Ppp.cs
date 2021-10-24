using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ppp
    {
        //Declaracion de atributos
        private string especialidad;
        private string nombreEmpresa;
        private string dia;
        private string sector;
        private string perfil;
        // Propiedades para los atriutos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Especialidad
        { 
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        // Declarancion de metodos u operaciones 
        public string Trabajar()
        {
            return "Este metodo trabajar recien será implementado";
        }
        public string Aprender()
        {
            return "Este metodo aprender recien será implementado";
        }
        public string DesarrollarProyectos()
        {
            return "Este metodo desarrollarProyectos recien será implementado";
        }
        public string Impulsar()
        {
            return "Este metodo impulsar recien será implementado";
        }
        public string Especializar()
        {
            return "Este metodo especializar recien sera implementado";
        }
        public string Conocer()
        {
            return "Este metodo conocer recein será implementado";
        }
    }
}
