using System;
using System.IO;
using ExemploPoo.Helper;
using ExemploPoo.Interfaces;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\Pedro\\Cursos\\DIO\\mrv\\poo\\Arquivos";
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6", "Lista 7" };

            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorio(Path.Combine(caminho, "Teste3", "Subteste3"));
            // helper.ApagarDiretorio(Path.Combine(caminho, "Teste1"), true);
            // helper.CriarArquivoTexto(Path.Combine(caminho, "Arquivo-Teste.txt"), "Teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(Path.Combine(caminho, "Arquivo-Teste-Stream.txt"), listaString);
            // helper.AdicionarTextoStream(Path.Combine(caminho, "Arquivo-Teste-Stream.txt"), listaStringContinuacao);
            // helper.LerArquivoStream(Path.Combine(caminho, "Arquivo-Teste-Stream.txt"));
            // helper.MoverArquivo(Path.Combine(caminho, "Arquivo-Teste-Stream.txt"), Path.Combine(caminho, "Teste2", "Arquivo-Teste-Stream.txt"), false);
            // helper.CopiarArquivo(Path.Combine(caminho, "Teste2", "Arquivo-Teste-Stream.txt"), Path.Combine(caminho, "Teste2", "Arquivo-Teste-bkp.txt"), false);
            helper.DeletarAquivo( Path.Combine(caminho, "Teste2", "Arquivo-Teste-bkp.txt"));


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(20, 10));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora ();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10, 10));
            

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 10;

            // p1.Apresentar();

            // // Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // // Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Area: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
