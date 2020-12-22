using System;
using System.Collections.Generic;
using _POO_Listas_de_Objetos.classes;

namespace _POO_Listas_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine("-----    ----------------------------");
            // Console.WriteLine("-----    Produtos");
            // Console.WriteLine("-----    ----------------------------");

            // // Criando Listas
            // List<Produto> produtos = new List<Produto>();

            // // INSERINDO Produtos diretamente.

            // produtos.Add(new Produto(1, "Arroz", 13.99f));
            // produtos.Add(new Produto(2, "Feijão", 11.99f));

            // //Cadastre Seu Produto

            // Console.Write("-----    Código do Produto: ");
            // int id = int.Parse( Console.ReadLine() );
            // Console.Write("-----    Nome do Produto: ");
            // string nome = Console.ReadLine();
            // Console.Write("-----    Preco do Produto: ");
            // float preco = float.Parse( Console.ReadLine() );
            // Console.WriteLine("-----    ----------------------------");

            // // Inserindo na lista
            // produtos.Add(new Produto(id, nome, preco));

            // //Exibindo a lista
            // foreach (var Produto in produtos)
            // {
                
            //     Console.WriteLine($"ID: {Produto.Id} Nome: {Produto.Nome}, Preço {Produto.Preco}");

            // }

            // //Excluir Item

            // Console.Write("Digite o ID Para Excluir: ");
            // int idSearch = int.Parse( Console.ReadLine() );
            // Console.WriteLine("-----    ----------------------------");

            // produtos.RemoveAll(x => x.Id == idSearch);

            // // ou

            // produtos.RemoveAt(0);

            // foreach (var Produto in produtos)
            // {
                
            //     Console.WriteLine($"ID: {Produto.Id} Nome: {Produto.Nome}, Preço {Produto.Preco}");

            // }

            // ------------------------------------------------------------------------------------------------------

            List<Cartao> cartoes = new List<Cartao>();

            string bandeira;
            string titular;
            string vencimento;
            string cvv;
            string numero;
            int repeat;

            Console.Write("Escreva Quanatos Itens Serão Cadastrados: ");
            repeat = int.Parse( Console.ReadLine() );
                

            for (var i = 1; i <= repeat; i++)
            {

            Console.WriteLine("-----    CADASTRO CARTAO");
            Console.Write("Bandeira: ");
            bandeira = Console.ReadLine();
            Console.Write("Titular: ");
            titular = Console.ReadLine();
            Console.Write("Vencimento (dd/mm/yyyy): ");
            vencimento = Console.ReadLine();
            Console.Write(" CVV: ");
            cvv = Console.ReadLine();
            Console.Write(" Numero: ");
            numero = Console.ReadLine();

            cartoes.Add(new Cartao(bandeira, titular, numero, cvv, vencimento));

            }

            // cartoes.Add(new Cartao("nubank", "vinicius", "123456", "123", "06/10/2029"));

            // foreach (var Cartao in cartoes)
            // {
                
            //     Console.WriteLine($"Bandeira {Cartao.Bandeira}, Titular: {Cartao.Titular}");

            // } 
            
        }
    }
}
