using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica6MC
{
    class Program
    {
        private static bool isNumber;

        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1 - Ejercicio 1");
                    Console.WriteLine("2 - Ejercicio 2");
                    Console.WriteLine("3 - Ejercicio 3");
                    Console.WriteLine("4 - Ejercicio 4");
                    Console.WriteLine("0 - Salir");
                    isNumber = int.TryParse(Console.ReadLine(), out opc);
                } while (isNumber == false || opc < 0);
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        static void Ejercicio1()
        {
            int tabla;
            do
            {
                Console.WriteLine("Ingrese el numero de la tabla a mostrar");
                isNumber = int.TryParse(Console.ReadLine(), out tabla);
            } while (isNumber == false || tabla < 1);
            Tabla(tabla);

            do
            {
                Console.WriteLine("Ingrese el numero de la tabla a mostrar");
                isNumber = int.TryParse(Console.ReadLine(), out tabla);
            } while (isNumber == false || tabla < 1);
            Tabla(tabla, ConsoleColor.Blue);
        }
        static void Tabla(int tabla)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", tabla, i, tabla * i);
            }
        }
        static void Tabla(int tabla, ConsoleColor  color)
        {
            Console.ForegroundColor = color;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", tabla, i, tabla * i);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Ejercicio2()
        {
            int ancho = 0, alto = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ancho del cuadrado");
                isNumber = int.TryParse(Console.ReadLine(), out ancho);
            } while (isNumber == false || ancho < 0);

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el alto del cuadrado");
                isNumber = int.TryParse(Console.ReadLine(), out alto);
            } while (isNumber == false || alto < 0);

            Dibujo(ancho, alto);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Ingrese el caracter para dibujar");
            char caracter = Convert.ToChar(Console.ReadLine());
            Dibujo(ancho, alto, caracter, 20,20);
        }

        private static void Dibujo(int ancho, int alto)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine("");
                Console.Write("");
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*  ");
                }
            }
        }
        private static void Dibujo(int ancho, int alto, char dibujo)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine("");
                Console.Write("");
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(dibujo + "  ");
                }
            }
        }
        private static void Dibujo(int ancho, int alto, char dibujo, int x, int y)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine("");
                Console.Write("");
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(dibujo + "  ");
                }
            }
        }

        private static void Ejercicio3()
        {
            int num = 0, exponente = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero base");
                isNumber = int.TryParse(Console.ReadLine(), out num);
            } while (isNumber == false);

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el exponente");
                isNumber = int.TryParse(Console.ReadLine(), out exponente);
            } while (isNumber == false);

            Console.WriteLine("Exponente de {0} es {1}", num, Elevar(num, exponente));
        }
        static int Elevar(int num, int exponente)
        {
            if (exponente < 1)
            {
                return 1;
            }
            return num * Elevar(num, exponente - 1);
        }

        private static void Ejercicio4()
        {
            int num;

            Console.WriteLine("Ingresa el numero para convertir en binario");
            num = int.Parse(Console.ReadLine());
            DecimalBinario(num);
        }

        private static void DecimalBinario(int num)
        {
            if (num<2)
            {
                Console.WriteLine(num);
            }
            else
            {
                DecimalBinario(num / 2);
                Console.WriteLine(num % 2);
            }
        }
    }
}
