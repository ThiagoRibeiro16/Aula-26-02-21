using System;

namespace Aula_26_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeDoAluno;


            Console.Clear();
            Console.Beep();

            Console.Write("Olá, aluno. Por fovor digite seu nome: ");
            NomeDoAluno =Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista de alunos malvados");
            Console.ReadKey();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("1. Zezinho");
            Console.WriteLine("2. Mariazinha");
            Console.WriteLine("3. Pedrinho");
            Console.WriteLine("4. Jorginho");
            Console.WriteLine($"5. {NomeDoAluno}" );
            
            Console.WriteLine();
            
            Console.WriteLine("Vão todos para diretoria!");
            Console.Beep();
            Console.ResetColor();
           
            Console.Write("Precione Uma tecla para continuar...");
            Console.ReadKey();
        }

    }
}
