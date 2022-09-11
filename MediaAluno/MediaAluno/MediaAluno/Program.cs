
namespace MediaAluno
{
    class Conclusao
    {
        static void Main()
        {
            double nota1, nota2, nota3;
            double media;
            Console.WriteLine("Olá, bem vindo(a) ao programa de cáculo da média \n");
            Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno \n");

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("\nA média do aluno é: {0}", media);
                Console.WriteLine("O aluno está aprovado");
            }
            else
            {
                Console.WriteLine("\nA média do aluno é: {0}", media);
                Console.WriteLine("O aluno está reprovado");
            }

            Console.ReadKey();
        }
    }
}
