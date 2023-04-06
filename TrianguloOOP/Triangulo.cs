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
                    Program.ColorirMensagem("\n>> Formato inválido, tente novamente: ", "NAO-QUEBRAR-LINHA", ConsoleColor.Red);
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
                    Program.ColorirMensagem("\n>> Formato inválido, tente novamente: ", "NAO-QUEBRAR-LINHA", ConsoleColor.Red);
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
                    Program.ColorirMensagem("\n>> Formato inválido, tente novamente: ", "NAO-QUEBRAR-LINHA", ConsoleColor.Red);
                    continuar = true;
                }
            }
        }
        public bool ValidarTriangulo()
        {
            bool ehValido = false;
            if (LadoX >= LadoY + LadoZ)
            {
                Program.ColorirMensagem("\n>> Triângulo Inválido.", "QUEBRAR-LINHA", ConsoleColor.Red);
                ehValido = true;
            }

            else if (LadoY >= LadoX + LadoZ)
            {
                Program.ColorirMensagem("\n>> Triângulo Inválido.", "QUEBRAR-LINHA", ConsoleColor.Red);
                ehValido = true;
            }

            else if (LadoZ >= LadoX + LadoY)
            {
                Program.ColorirMensagem("\n>> Triângulo Inválido.", "QUEBRAR-LINHA", ConsoleColor.Red);
                ehValido = true;
            }

            return ehValido;
        }
        public void EncontrarTipoTriangulo()
        {
            if (LadoX != LadoY && LadoX != LadoZ && LadoY != LadoZ)
                Program.ColorirMensagem(">> Triângulo escaleno", "QUEBRAR-LINHA", ConsoleColor.Green);
            else if (LadoX == LadoY && LadoX == LadoZ && LadoY == LadoZ)
                Program.ColorirMensagem(">> Triângulo equilátero", "QUEBRAR-LINHA", ConsoleColor.Green);
            else if (LadoX == LadoY || LadoX == LadoZ || LadoY == LadoZ)
                Program.ColorirMensagem(">> Triângulo isóceles", "QUEBRAR-LINHA", ConsoleColor.Green);
            else
                Program.ColorirMensagem(">> Triângulo Inválido", "QUEBRAR-LINHA", ConsoleColor.Red);
        }
    }
}
