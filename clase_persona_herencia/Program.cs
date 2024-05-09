using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_persona_herencia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //el método se va a repetir en las 4 clases para pedir la edad, el nombre y la fecha de nacimiento
    //clase papá 
    //creamos una clase pública para persona
    public class Persona
    {
        //creamos un string para nombre y fecha de nacimiento porque es un elemento de texto
        //creamos un elemento int para edad porque es un elemento numérico
        //utilizamos get y set para que tome los datos y los devuelva
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Fechanacimiento { get; set; }
        public Persona(string nombre, int edad, string fechanacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanacimiento = fechanacimiento;
        }

        //este comando nos permite mostrar la información solicitada 
        public void MostarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Fechanacimiento: {Fechanacimiento}");
        }
    }

    //clase hija 
    //creamos una clase pública para alumno
    public class Alumno
    {
        //creamos un string para nombre y fecha de nacimiento porque es un elemento de texto
        //creamos un elemento int para edad porque es un elemento numérico
        //utilizamos get y set para que tome los datos y los devuelva
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Fechanacimiento { get; set; }
        public Alumno(string nombre, int edad, string fechanacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanacimiento = fechanacimiento;
        }

        //este comando nos permite mostrar la información solicitada
        public void MostarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Fechanacimiento: {Fechanacimiento}");
        }
    }

    //clase hija
    //creamos una clase pública para empleado
    public class Empleado
    {
        //creamos un string para nombre y fecha de nacimiento porque es un elemento de texto
        //creamos un elemento int para edad porque es un elemento numérico
        //utilizamos get y set para que tome los datos y los devuelva
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Fechanacimiento { get; set; }
        public Empleado(string nombre, int edad, string fechanacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanacimiento = fechanacimiento;
        }

        //este comando nos permite mostrar la información solicitada
        public void MostarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Fechanacimiento: {Fechanacimiento}");
        }
    }

    //clase hija
    //creamos una clase pública para docente
    public class Docente
    {
        //creamos un string para nombre y fecha de nacimiento porque es un elemento de texto
        //creamos un elemento int para edad porque es un elemento numérico
        //utilizamos get y set para que tome los datos y los devuelva
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Fechanacimiento { get; set; }
        public Docente(string nombre, int edad, string fechanacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanacimiento = fechanacimiento;
        }

        //este comando nos permite mostrar la información solicitada
        public void MostarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad} Fechanacimiento: {Fechanacimiento}");
        }
    }
}



