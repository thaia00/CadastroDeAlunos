using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDeAlunos
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string curso)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Curso: {Curso}";
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("1. Cadastrar aluno");
                Console.WriteLine("2. Listar alunos cadastrados");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarAluno(alunos);
                        break;
                    case "2":
                        ListarAlunos(alunos);
                        break;
                    case "0":
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (opcao != "0")
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != "0");
        }

        static void CadastrarAluno(List<Aluno> alunos)
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Aluno");

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o curso do aluno: ");
            string curso = Console.ReadLine();

            alunos.Add(new Aluno(nome, idade, curso));

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static void ListarAlunos(List<Aluno> alunos)
        {
            Console.Clear();
            Console.WriteLine("Lista de Alunos Cadastrados");

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
            }
            else
            {
                foreach (var aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }
            }
        }
    }
}