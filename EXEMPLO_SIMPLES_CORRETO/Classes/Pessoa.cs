using System;

namespace EXEMPLO_SIMPLES_CORRETO.Classes
{
    public class Pessoa
    {
        public string Nome { get; }
        public string SobreNome { get; }
        public int Idade { get; }
        public Endereco Endereco { get; }

        public Pessoa(string nome, string sobreNome, int idade, Endereco endereco)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Idade = idade;

            Endereco = endereco;
        }

        public void MostraInformacoesCompletaDaPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"SobreNome: {SobreNome}");
            Console.WriteLine($"Idade: {Idade}");
        }

        public void MostraInformacoesCompletaDoEnderecoDaPessoa()
        {
            Endereco.MostraInformacoesCompletaDoEnderecoDaPessoa();
        }

    }
}
