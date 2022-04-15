using System;

namespace EXEMPLO_SIMPLES_ERRADO.Classes
{
    public class Pessoa
    {
        public string Nome { get; }
        public string SobreNome { get; }
        public int Idade { get; }
        public string Cep { get; }
        public string Bairro { get; }
        public string Cidade { get; }

        public Pessoa(string nome, string sobreNome, int idade, string cep, string bairro, string cidade)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Idade = idade;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
        }

        public void MostraInformacoesCompletaDaPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"SobreNome: {SobreNome}");
            Console.WriteLine($"Idade: {Idade}");
        }

        public void MostraInformacoesCompletaDoEnderecoDaPessoa()
        {
            Console.WriteLine($"Cep: {Cep}");
            Console.WriteLine($"Bairro: {Bairro}");
            Console.WriteLine($"Cidade: {Cidade}");
        }
    }
}
