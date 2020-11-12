using System;

namespace Condicionais1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet new console(cria um projeto para console)
            //dotnet run Execulta o código.
            //Exibe no console uma mensagem.

            // int idade;

            // idade = 32; 
            // nomeCompleto = "Lameck Vieira Barbosa";
            // Console.WriteLine("Nome do filho");

            // //Exiba o segundo nome
            // nomeMae = "Alzerina";
            // Console.WriteLine("Nome da mãe");

            // Console.WriteLine ();

            // String nome = "Lameck";

            // int a = 1;
            // int b = 4;
            // a <= b;

            //Declarar as Variaveis

            float nota1, nota2, nota3, media;
            string nomeCompleto;
            
            // byte
            // shyte
            // short
            // ushort
            // double 
            


            //Entrada de dados

            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processando

            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado
            if(media>5){
                //valor Verdadeiro
                Console.WriteLine("o aluno "+nomeCompleto+" está Aporvado");
            }
            else{
                //Valor Falso
                Console.WriteLine("o aluno "+nomeCompleto+" está Reporvado");
            }









        }
    }
}
