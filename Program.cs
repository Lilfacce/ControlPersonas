using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonas
{
    class Persona
    {
        //Campos 
        //Privados para cumplir con
        //el encapsulado

        string dpi;
        string nombre;
        string apellido;


        //Camel case
        DateTime fechaNacimiento;

        //Encapsulado
        public String Dpi { get => dpi; set => dpi = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento; set => fechaNacimiento = value;
        }

        //Métodos: Acciones que se realizan

        //Constructor de la clase:
        //Codigo que se ejecuta al crearse un objeto de esta clase
        //por ejemplo inicializar variables
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            //inicializar con la fecha de hoy
            fechaNacimiento = DateTime.Now;
        }

        public void PrimeraMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                nombre = nombreMayuscula.ToString();

            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }
        public int Edad()
        {
            int mes = fechaNacimiento.Month;
            int anio = fechaNacimiento.Year;
            int edad;
            int mesnow = DateTime.Now.Month;



            edad = 2024 - anio;
            if (mesnow > mes)
            {
                return edad;
            }
            if (mesnow == mes)
            {
                return edad;
            }
            if (mesnow < mes)
            {
                edad = edad - 1;
                return edad;
            }
            //Calcular la Edad 
            return edad;

        }
        public void NormalizarNombre()
        {
            //Eliminar espacios en blanco
            string NSinEsp = nombre.Trim();
            string apellidos = apellido.Trim();

            //Eliminar simbolos 
            StringBuilder nombreSimbolos = new StringBuilder();
            foreach (char c in NSinEsp)
            {
                if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                {
                    nombreSimbolos.Append(c);
                }
            }
            string nombreSinSimbolos = nombreSimbolos.ToString();

            StringBuilder apellidoSimbolos = new StringBuilder();
            foreach (char c in apellidos)
            {
                if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                {
                    apellidoSimbolos.Append(c);
                }
            }
            string apellidosSinSimbolos = apellidoSimbolos.ToString();

            nombre = nombreSinSimbolos;
            apellido = apellidosSinSimbolos;
        }



    }