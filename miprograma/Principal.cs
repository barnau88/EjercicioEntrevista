using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;  


namespace miprograma
{
    class Principal
    {
        public static String rutaFichOrigen;
        public static String rutaFichDestino;
        public static String textBuscar;
        public static String textRemplazar;
        public static int contador;

        static void Main(string[] args)
        {
            if (args.Length == 4)
            {
             
                rutaFichOrigen  = args[0];
                rutaFichDestino = args[1];
                textBuscar      = args[2];
                textRemplazar   = args[3];

                if (rutaFichOrigen.Contains("origen.txt") == false)
                {
                    Console.Write("No existe el fichero origen");
                    return;
                }
               
                String linea;

                try {

                StreamReader ficheroLectura = new StreamReader(rutaFichOrigen);
                StreamWriter ficheroEscritura = new StreamWriter(rutaFichDestino);
                linea = ficheroLectura.ReadLine();

                while (linea != null)
                {
                    if (linea.Contains(textBuscar))
                    {
                        contador = contador+1;
                        linea = linea.Replace(textBuscar, textRemplazar);
                        
                    }
                    ficheroEscritura.WriteLine(linea);
                    linea = ficheroLectura.ReadLine();
                }

                ficheroEscritura.Close();
                ficheroLectura.Close();
                Console.Write(contador + " líneas modificadas");
                Console.ReadLine();
                

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
              
            }
            else
            {
                if(args.Length < 4)
                {
                    Console.Write("Número de parámetros insuficientes, introduce cuatro parametros");
                }
                if (args.Length > 4)
                {
                    Console.Write("Demasiados parámetros, introduce cuatro parametros");
                }
                
                
            }
        }
    }
}
