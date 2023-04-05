using System;
using System.Text;

namespace TrianguloOOP
{
    internal class Triangulo
    {

        public int LadoX { get; set; }
        public int LadoY { get; set; }
        public int LadoZ { get; set; }

        public void ObterLados()
        {
            bool continuar = true;

            Console.Write("\n>> Insira o primeiro lado: ");

            while (continuar == true)
            {
                try
                {
                    LadoX = Convert.ToInt32(Console.ReadLine());
                    continuar = false;
                }
                catch(FormatException) 
                {
                    Console.Write("\n>> Formato inválido, tente novamente: ");
                    continuar = true;
                }               
            }

            continuar = true;

            Console.Write("\n>> Insira o segundo lado: ");

            while (continuar == true)
            {
                try
                {
                    LadoY = Convert.ToInt32(Console.ReadLine());
                    continuar = false;
                }
                catch (FormatException)
                {
                    Console.Write("\n>> Formato inválido, tente novamente: ");
                    continuar = true;
                }
            }

            continuar = true;

            Console.Write("\n>> Insira o terceiro lado: ");

            while (continuar == true)
            {
                try
                {
                    LadoZ = Convert.ToInt32(Console.ReadLine());
                    continuar = false;
                }
                catch (FormatException)
                {
                    Console.Write("\n>> Formato inválido, tente novamente: ");
                    continuar = true;
                }
            }
        }
        public bool ValidarTriangulo()
        {
            bool ehValido = false;
            if (LadoX >= LadoY + LadoZ)
            {
                Console.WriteLine(">> Triângulo Inválido.");
                ehValido = true;
            }

            else if (LadoY >= LadoX + LadoZ)
            {
                Console.WriteLine(">> Triângulo Inválido.");
                ehValido = true;
            }

            else if (LadoZ >= LadoX + LadoY)
            {
                Console.WriteLine(">> Triângulo Inválido.");
                ehValido = true;
            }

            return ehValido;
        }
        public void EncontrarTipoTriangulo()
        {
            if (LadoX != LadoY && LadoX != LadoZ && LadoY != LadoZ)
                Console.WriteLine(">> Triângulo escaleno");
            else if (LadoX == LadoY && LadoX == LadoZ && LadoY == LadoZ)
                Console.WriteLine(">> Triângulo equilátero");
            else if (LadoX == LadoY || LadoX == LadoZ || LadoY == LadoZ)
                Console.WriteLine(">> Triângulo isóceles");
            else
                Console.WriteLine(">> Triângulo Inválido");
        }
    }
}
