namespace TrianguloOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new();

            ColorirMensagem("------ Triangulo Orientado à Objetos ------\n", "QUEBRAR-LINHA", ConsoleColor.Green);
            Console.WriteLine(">> Insira os lados do triângulo.");
            ColorirMensagem("\n>> A medida de um dos lados deve ser menor que a soma dos outros dois lados", "QUEBRAR-LINHA", ConsoleColor.Yellow);

            triangulo.ObterLados();
            if (triangulo.ValidarTriangulo() == true)
                Environment.Exit(0);

            triangulo.EncontrarTipoTriangulo();          
        }
        public static void ColorirMensagem(string mensagem, string tipoDeMensagem, ConsoleColor cor)
        {
            if (tipoDeMensagem == "QUEBRAR-LINHA")
            {
                Console.ForegroundColor = cor;
                Console.WriteLine(mensagem);
                Console.ResetColor();
            }

            else if (tipoDeMensagem == "NAO-QUEBRAR-LINHA")
            {
                Console.ForegroundColor = cor;
                Console.Write(mensagem);
                Console.ResetColor();
            }
            
        }
    }
}