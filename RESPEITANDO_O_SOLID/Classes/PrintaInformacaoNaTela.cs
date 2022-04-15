using System;

namespace RESPEITANDO_O_SOLID.Class
{
    public static class PrintaInformacaoNaTela
    {
        private const string LINHA_DE_CORTE = "==================================================================";
        private static void GeraLinhaDeDivisao() => Console.WriteLine(LINHA_DE_CORTE);

        public static void IndicaOInicioDaPartida()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; //Muda a cor do console

            Console.WriteLine("A partida vai começar!");
            Console.WriteLine("O round inicial é do player um!");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.Black;

            TemporizadorDaTela.DormirTempoLongo();
        }

        public static string GeraPalavraParaAcertar(string palavraAMostrarNaTela)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            GeraLinhaDeDivisao();
            Console.WriteLine($"Vez do player: {ControladorDeRound.InformaDeQualPlayerEhARodada()}");
            Console.WriteLine($"Digite quantas letras tem essa palavra: {palavraAMostrarNaTela}");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            return Console.ReadLine();
        }

        public static string PerguntaNovamenteProPlayerSobreAPalavra(string palavraAMostrarNaTela)
        {
            TemporizadorDaTela.DormirRapidamente();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            GeraLinhaDeDivisao();
            Console.WriteLine($"Numero inválido, por favor {ControladorDeRound.InformaDeQualPlayerEhARodada()} digite um numero valido");
            Console.WriteLine($"Digite quantas letras tem essa palavra: {palavraAMostrarNaTela}");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            return Console.ReadLine();
        }

        public static void MostraPontuacao()
        {
            TemporizadorDaTela.DormirTempoMedio();

            Console.ForegroundColor = ConsoleColor.Green;

            GeraLinhaDeDivisao();
            Console.WriteLine($"Pontuacao do P1: {ControladorDePontuacao.PontuacaoPlayerUm}");
            Console.WriteLine($"Pontuacao do P2: {ControladorDePontuacao.PontuacaoPlayerDois}");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            TemporizadorDaTela.DormirTempoMedio();

            Console.Clear();
        }

        public static void MostraPontuacaoEIndicaGanhador()
        {
            MostraPontuacao();

            TemporizadorDaTela.DormirRapidamente();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            GeraLinhaDeDivisao();
            Console.WriteLine($"O ganhador foi: {ControladorDePontuacao.DefiniGanhador()}");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            TemporizadorDaTela.DormirTempoLongo();

            Console.Clear();
        }

        public static void FinalizarAPartida()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

            GeraLinhaDeDivisao();
            Console.WriteLine("Partida encerrada, obrigado por jogar nosso jogo!");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            TemporizadorDaTela.DormirTempoLongo();
            Console.Clear();
        }

        public static void Errou()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            GeraLinhaDeDivisao();
            Console.WriteLine($"{ControladorDeRound.InformaDeQualPlayerEhARodada()} errou!!!");

            MostraPlacarDeErro();

            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            TemporizadorDaTela.DormirTempoMedio();
            Console.Clear();
        }

        public static void Acertou()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            GeraLinhaDeDivisao();
            Console.WriteLine($"{ControladorDeRound.InformaDeQualPlayerEhARodada()} acertou!!!");
            GeraLinhaDeDivisao();

            Console.ForegroundColor = ConsoleColor.White;

            TemporizadorDaTela.DormirTempoMedio();
            Console.Clear();
        }

        public static void MostraPlacarDeErro()
        {
            Console.WriteLine("Os players so podem errar 3X");

            GeraLinhaDeDivisao();

            Console.WriteLine();
            Console.WriteLine($"Quantas vezes P1 errou: {ControladorDePontuacao.QuantasVezesPlayerUmErrou}");
            Console.WriteLine($"Quantas vezes P2 errou: {ControladorDePontuacao.QuantasVezesPlayerDoisErrou}");
            Console.WriteLine();

            GeraLinhaDeDivisao();
        }
    }
}
