using System;
using System.Collections.Generic;
using _POO_Listas_de_Objetos.classes;

namespace _POO_Listas_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----    ----------------------------");
            Console.WriteLine("-----    Produtos");
            Console.WriteLine("-----    ----------------------------");

            // Criando Listas
            List<Produto> produtos = new List<Produto>();

            // INSERINDO Produtos diretamente.

            produtos.Add(new Produto(1, "Arroz", 13.99f));
            produtos.Add(new Produto(2, "Feijão", 11.99f));

            //Cadastre Seu Produto

            Console.Write("-----    Código do Produto: ");
            int id = int.Parse( Console.ReadLine() );
            Console.Write("-----    Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("-----    Preco do Produto: ");
            float preco = float.Parse( Console.ReadLine() );
            Console.WriteLine("-----    ----------------------------");

            // Inserindo na lista
            produtos.Add(new Produto(id, nome, preco));

            //Exibindo a lista
            foreach (var Produto in produtos)
            {
                
                Console.WriteLine($"ID: {Produto.Id} Nome: {Produto.Nome}, Preço {Produto.Preco}");

            }

            //Excluir Item

            Console.Write("Digite o ID Para Excluir: ");
            int idSearch = int.Parse( Console.ReadLine() );
            Console.WriteLine("-----    ----------------------------");

            produtos.RemoveAll(x => x.Id == idSearch);

            // ou

            produtos.RemoveAt(0);

            foreach (var Produto in produtos)
            {
                
                Console.WriteLine($"ID: {Produto.Id} Nome: {Produto.Nome}, Preço {Produto.Preco}");

            }
            
        }
    }
}
