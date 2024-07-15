using System;
using System.IO;

namespace LeerArchivo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese la ruta del directorio:");
            string directorio = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del archivo a procesar:");
            string nombreArchivo = Console.ReadLine();

            try
            {
                bool lectura = LecturaArchivo(directorio, nombreArchivo);
                if (lectura)
                {
                    Console.WriteLine($"Leyendo el archivo {nombreArchivo}...");

                    // Lee el contenido del archivo
                    string contenido = File.ReadAllText(Path.Combine(directorio, nombreArchivo));

                    // Realiza cambios en el contenido
                    string contenidoModificado = ModificaContenido(contenido);

                    // Muestra los cambios por pantalla
                    Console.WriteLine("Contenido modificado:");
                    Console.WriteLine(contenidoModificado);

                    Console.WriteLine("Ingrese el nombre del archivo de salida:");
                    string nombreArchivoSalida = Console.ReadLine();
                    string rutaSalidaCompleta = Path.Combine(directorio, nombreArchivoSalida);

                    // Escribe el contenido modificado en un nuevo archivo
                    File.WriteAllText(rutaSalidaCompleta, contenidoModificado);

                    Console.WriteLine($"Se ha creado el archivo {nombreArchivoSalida} con los cambios realizados.\nDigite una tecla para finalizar");
                    Console.ReadKey();
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Digite una tecla para finalizar");
                Console.ReadKey();
            }
        }

        public static bool LecturaArchivo(string directorio, string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(directorio, nombreArchivo);

            if (!File.Exists(rutaCompleta))
            {
                Console.WriteLine("El archivo especificado no existe.\nDigite una letra para finalizar");
                Console.ReadKey(); //Para pruebas unitarias se debe comentar esta linea
                return false;
            }
            else
                return true;
        }

        public static string ModificaContenido(string contenido)
        {
            Console.WriteLine($"Contenido: \n{contenido}");
            Console.WriteLine("Digite el contenido a modificar");
            contenido = Console.ReadLine(); //Para pruebas unitarias se debe comentar esta linea
            return contenido;
        }
    }
}
