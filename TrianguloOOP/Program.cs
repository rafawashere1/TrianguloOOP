namespace TrianguloOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new();

            Console.WriteLine("------ Triangulo Orientado à Objetos ------\n");

            Console.WriteLine(">> Insira os lados do triângulo.\n>> A medida de um dos lados deve ser menor que a soma dos outros dois lados");

            triangulo.ObterLados();

            if (triangulo.ValidarTriangulo() == true)
                Environment.Exit(0);

            triangulo.EncontrarTipoTriangulo();
            
        }
    }
}