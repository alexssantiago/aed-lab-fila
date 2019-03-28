using RockInRio.Dominio;
using System;

namespace RockInRio
{
    class Program
    {
        //TESTE DE IMPLEMENTAÇÃO DA FILA
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            int users = 3;

            while (users > 0)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o cpf: ");
                string cpf = Console.ReadLine();

                Usuario usuario = new Usuario
                {
                    Nome = nome,
                    Cpf = cpf
                };

                fila.Inserir(usuario);
                Console.WriteLine($"{usuario.Nome} entrou na fila.");

                users--;
            }

            users = 3;
            while (users > 0)
            {
                Console.WriteLine($"\n{fila.Retirar()} saiu da fila.");
                users--;
            }

            Console.ReadKey();
        }
    }
}
