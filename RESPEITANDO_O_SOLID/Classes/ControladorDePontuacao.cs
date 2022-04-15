using System;

namespace RESPEITANDO_O_SOLID.Class
{
    public static class ControladorDePontuacao
    {
        public static int PontuacaoPlayerUm { get; set; }
        public static int QuantasVezesPlayerUmErrou { get; private set; }
        public static int PontuacaoPlayerDois { get; set; }
        public static int QuantasVezesPlayerDoisErrou { get; private set; }

        public static int NUMERO_MAXIMO_DE_ERROS { get; } = 3;

        public static void AumentaPontuacao()
        {
            var ehRodadaDoPlayerUm = ControladorDeRound.RodadaDeQuem == Rodada.RodadaPlayerUm;
            var ehRodadaDoPlayerDois = ControladorDeRound.RodadaDeQuem == Rodada.RodadaPlayerDois;

            if (ehRodadaDoPlayerUm)
                PontuacaoPlayerUm++;

            if (ehRodadaDoPlayerDois)
                PontuacaoPlayerDois++;
        }

        public static void SetaErroDoPlayer()
        {
            var ehRodadaDoPlayerUm = ControladorDeRound.RodadaDeQuem == Rodada.RodadaPlayerUm;
            var ehRodadaDoPlayerDois = ControladorDeRound.RodadaDeQuem == Rodada.RodadaPlayerDois;

            if (ehRodadaDoPlayerUm)
            {
                QuantasVezesPlayerUmErrou++;
            }

            if(ehRodadaDoPlayerDois)
            {
                QuantasVezesPlayerDoisErrou++;
            }
        }

        public static bool DefineSeAPartidaAcabou()
        {
            var alguemErrouTresVezesOuMais = QuantasVezesPlayerUmErrou >= NUMERO_MAXIMO_DE_ERROS || QuantasVezesPlayerDoisErrou >= NUMERO_MAXIMO_DE_ERROS;

            if(alguemErrouTresVezesOuMais)
            {
                return true;
            }

            return false;
        }

        public static string DefiniGanhador()
        {
            var playerUmEhOGanhador = PontuacaoPlayerUm > PontuacaoPlayerDois;

            if (playerUmEhOGanhador)
                return "P1";

            var playerDoisEhOGanhador = PontuacaoPlayerDois > PontuacaoPlayerDois;

            if (playerDoisEhOGanhador)
                return "P2";

            return string.Empty;
        }
    }
}
