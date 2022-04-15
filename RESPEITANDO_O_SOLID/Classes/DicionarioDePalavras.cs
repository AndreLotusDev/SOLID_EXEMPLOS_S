using System;
using System.Collections.Generic;

namespace RESPEITANDO_O_SOLID.Class
{
    public static class DicionarioDePalavras
    {
        private static List<string> PalavrasPermitidas = new List<string> { "Batata", "Cenoura", "Miojo", "Alface", "Trigo", "Alfafa", "Bola", "Fugitivo", "Prisão", "Carro", "Supermercado", "Loja", "Shopping" };

        public static string GeraPalavraRandomica()
        {
            var rangeDoDicionario = PalavrasPermitidas.Count - 1;
            var numeroAleatorioGerado = new Random().Next(0, rangeDoDicionario);

            var palavraSelecionadaAleatoriamente = PalavrasPermitidas[numeroAleatorioGerado];

            return palavraSelecionadaAleatoriamente;
        }

        public static bool VerificaSeEhUmNumeroValido(string numeroAValidar)
        {
            var ehUmNumeroValido = int.TryParse(numeroAValidar, out int numeroFormatado);

            return ehUmNumeroValido;
        }

        public static bool ComparaDuasPalavras(int lenghtDapalavraQueOPlayerDigitou, int lengthpalavraParaComprar)
        {
            var saoIguais = lenghtDapalavraQueOPlayerDigitou == lengthpalavraParaComprar;

            if (saoIguais)
            {
                return true;
            }

            if(!saoIguais)
            {
                return false;
            }

            return false;
        }
    }
}
