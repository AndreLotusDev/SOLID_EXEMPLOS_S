using System;

namespace EXEMPLO_SIMPLES_CORRETO.Classes
{
    public class Endereco
    {
        
        public string Cep { get; }
        public string Bairro { get; }
        public string Cidade { get; }

        public Endereco(string cep, string bairro, string cidade)
        {
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
        }

        public void MostraInformacoesCompletaDoEnderecoDaPessoa()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"Cep: {Cep}");
            Console.WriteLine($"Bairro: {Bairro}");
            Console.WriteLine($"Cidade: {Cidade}");

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
