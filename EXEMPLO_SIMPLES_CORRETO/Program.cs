using EXEMPLO_SIMPLES_CORRETO.Classes;
using System;

namespace EXEMPLO_SIMPLES_CORRETO
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaPessoa = new Pessoa("Andre", "Soares Gomes", 22, new Endereco("88701-300", "Coqueiros", "Varzea Da Palma"));

            minhaPessoa.MostraInformacoesCompletaDaPessoa();
            minhaPessoa.MostraInformacoesCompletaDoEnderecoDaPessoa();

            Console.ReadLine();
        }
    }
}
