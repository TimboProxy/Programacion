using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Listas
    {
        private List<Nombre> _nombres;
        private List<Info> _infos;
        private List<Genero> _generos;

        public Listas()
        {
            _nombres = new List<Nombre>();
            _infos = new List<Info>();
            _generos = new List<Genero>();
                
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1.- Insertar Pelicula");
                Console.WriteLine("2.- Buscar pelicula");
                Console.WriteLine("3.- Salir");
            } while (!validaMenu(3,ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1: ShowMenuPeliculas(); 
                        break;
                case 2: ShowCatalogo();
                        break;
                case 3: break;
            }
        }

        private void ShowCatalogo()
        {
            throw new NotImplementedException();
        }

        private void ShowMenuPeliculas()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("----Peliculas----");
                Console.WriteLine("1.- Insertar Nombre de Pelicula");
                Console.WriteLine("2.- Insertar Informacion de Pelicula");
                Console.WriteLine("3.- Insertar Genero de Pelicula");
                Console.WriteLine("4.- Regresar");
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:InsertarNombre();
                    String nombre;
                    Console.WriteLine("----Insertando Nombre----");
                    do
                    {
                        Console.Write("Nombre:");
                        nombre = Console.ReadLine();
                        if (nombre == null || nombre == "")
                        {
                            Console.Write("Nombre invalido");
                        }
                    } while (true);
                    Nombre nuevoNombre = new Nombre(nombre);
                    _nombres.Add(nuevoNombre);
                    Console.WriteLine("Nombre agregado correctamente, Presiona enter para continuar...");
                    Console.ReadLine();
                    ShowMenuPeliculas();
                    break;


                case 2: InsertarInfo();
                    String info;
                    Console.WriteLine("----Insertando Información----");
                    do
                    {
                        Console.Write("Informacion:");
                        info = Console.ReadLine();
                        if (info == null || info == "")
                        {
                            Console.Write("info invalida");
                        }
                    } while (true);
                    Info nuevainfo = new Info(info);
                    _infos.Add(nuevainfo);
                    Console.WriteLine("Información agregada correctamente, Presiona enter para continuar...");
                    Console.ReadLine();
                    ShowMenuPeliculas();
                    break;


                case 3: InsertarGenero();
                    String genero;
                    Console.WriteLine("----Insertando Genero----");
                    do
                    {
                        Console.Write("Genero:");
                        genero = Console.ReadLine();
                        if (genero == null || genero == "")
                        {
                            Console.Write("Genero invalido");
                        }
                    } while (true);
                    Genero nuevogenero = new Genero(genero);
                    _generos.Add(nuevogenero);
                    Console.WriteLine("Genero agregada correctamente, Presiona enter para continuar...");
                    Console.ReadLine();
                    ShowMenuPeliculas();
                    break;

                case 4:
                    showMenuPrincipal();
                    break;
            }
        }

        private void InsertarNombre()
        {
            throw new NotImplementedException();
        }

        private void InsertarInfo()
        {
            throw new NotImplementedException();
        }

        private void InsertarGenero()
        {
            throw new NotImplementedException();
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n)) {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es valido, ingresa un numero.");
                return false;
            }
        }


    }
}
