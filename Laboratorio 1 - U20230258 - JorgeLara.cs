using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //PARTE I


            //Declaracion de variables tipo texto capturando valor desde consola
            string? departamento;
            string? municipio;
            string? ciudad;

            //Declaracion de variables tipo texto asignando su valor desde la declaracion
            string? colonia_en_la_que_vive = "Barrio el centro";
            string? color_de_casa = "Aqua";

            //Declaracion de dos variables de tipo enteras asignando su valor desde consola
            int años_de_vivir_en_su_residencia_actual;
            int edad_actual;
            
            //Declaracion de dos variables de tipo date time asignando su valor desde la declaracion
            DateTime FechaNacimiento = new DateTime(00, 3, 12, 21, 15,00);
            DateTime FechaActual = DateTime.Now;

            //Obtencion de datos desde la terminal
            Console.WriteLine("Ingrese su departamento: ");
            departamento = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ingrese su municipio: ");
            municipio = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su ciudad: ");
            ciudad = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese sus años de vivir en su residencia actual: ");
            años_de_vivir_en_su_residencia_actual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual: ");
            edad_actual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            //PARTE II


            //Aplicar función para comparar cadenas
            bool cadenaComparativa = departamento == municipio;

            //Aplicar función para concatenar texto
            string? cadenaConcatenada = municipio + " " + ciudad;

            //Aplicar función de mayúscula
            string? funcionMayuscula1 = departamento.ToLower();
            string? funcionMayuscula2 = municipio.ToUpper();

            //Aplicar función de limpiado de cadena
            string? funcion_limpiado = ciudad.Trim();

            //Aplicar función de longitud de cadena, al menos a dos variables
            int llongitudCadena1=municipio.Length;
            int llongitudCadena2=ciudad.Length;


            //Aplicar función de formateo de fecha mostrarla en día/mes/año
            string fechaFormateada = FechaActual.ToString(" dd/MM/yyyy");

            //Adicionar 2 semanas a cada fecha ingresada
            DateTime fechaSumada = FechaNacimiento.AddDays(14);
            DateTime fechaSumada2 = FechaActual.AddDays(14);

            //Comparar las fechas, fecha1 mayor a fecha2 y fecha1 menor a fecha2
            bool fecha_igual = FechaActual == FechaNacimiento;
            bool Fecha_Nacimiento = FechaActual < FechaNacimiento;
            bool Fecha_Actual = FechaActual > FechaNacimiento;


            //PARTE III


            //Imprimir de los valores ingresados de las variables de texto, Imprimir los valores de las variables enteras, Imprimir en consola los valores ingresados en las comparaciones de cadenas, Imprimir en consola los valores obtenidos de las funciones de fecha

            Console.Write("\n------- IMPRESION DE VALORES INGRESADOS DE LAS VARIABLES DE TEXTO ---------");
            Console.WriteLine("Su departamento es: " + departamento);
            Console.WriteLine("Su municipio es: " + municipio);
            Console.WriteLine("Su ciudad es: " + ciudad);
            Console.WriteLine("Su colonia de residencia es: " + colonia_en_la_que_vive);
            Console.WriteLine("Su color de vivienda es: " + color_de_casa);
            Console.WriteLine("********************FIN DE IMPRESION**************\n\n");
            Console.Write("\n------- IMPRESION DE VALORES DE LAS VARIABLES ENTERAS ---------");
            Console.WriteLine("Sus años de residencia actual es: " + años_de_vivir_en_su_residencia_actual);
            Console.WriteLine("Su edad actual es: " + edad_actual);
            Console.WriteLine("********************FIN DE IMPRESION**************\n\n");
            Console.Write("\n------- IMPRESION DE VALORES INGRESADOS EN LAS COMPARACIONES DE CADENAS ---------");
            Console.Write("\n-- Funcion en cadena comparativa >>> "+ cadenaComparativa);
            Console.Write("\n-- Funcion en cadena concatenada >>> "+ cadenaConcatenada);
            Console.Write("\n-- Funcion en mayuscula 1 >>> "+ funcionMayuscula1);
            Console.Write("\n-- Funcion en mayuscula 2 >>> "+ funcionMayuscula2);
            Console.Write("\n-- Funcion en limpiado >>> "+ funcion_limpiado);
            Console.Write("\n-- Funcion en longitud de cadena 1 >>> "+ llongitudCadena1);
            Console.Write("\n-- Funcion en longitud de cadena 2 >>> "+ llongitudCadena2);
            Console.WriteLine("********************FIN DE IMPRESION**************\n\n");
            Console.Write("\n------- IMPRESION DE VALORES INGRESADOS DE LAS VARIABLES DE TEXTO ---------");
            Console.Write("\n-- Fecha de nacimiento >>> "+ FechaNacimiento);
            Console.Write("\n-- Fecha actual >>> "+ FechaActual);
            Console.Write("\n-- Fecha de nacimiento >>> "+ FechaNacimiento);
            Console.Write("\n-- Fecha formateada >>> "+ fechaFormateada);
            Console.Write("\n-- Fecha sumada >>> "+ fechaSumada);
            Console.Write("\n-- Fecha sumada 2 >>> "+ fechaSumada2);
            Console.Write("\n-- Fecha comparada >>> "+ fecha_igual);
            Console.Write("\n-- Fecha 1 mayor a Fecha 2 >>> "+ Fecha_Actual);
            Console.Write("\n-- Fecha 1 menor a Fecha 2 >>> "+ Fecha_Nacimiento);
            Console.WriteLine("********************FIN DE IMPRESION**************\n\n");


            //AUTOEVALUACION: 10.00


            //- U20230258 - JORGE HUMBERTO LARA RODEZNO -
        }
    }
}