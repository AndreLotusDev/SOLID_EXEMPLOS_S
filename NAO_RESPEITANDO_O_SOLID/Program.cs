using System;
using System.Collections.Generic;
using System.Threading;

namespace NAO_RESPEITANDO_O_SOLID
{
    class Program
    {
        class JogoDeExemplo 
        {
            private List<string> PalavrasPermitidas = new List<string> { "batata", "cenoura", "miojo", "alface", "trigo", "alfafa", "bola", "fugitivo", "prisão", "carro", "supermercado", "loja", "shopping" };
            private int PontuacaoCaraUm { get; set; }
            private int QuantasVezesOCaraUmErrou { get; set; }
            private int PontuacaoCaraDois { get; set; }
            private int QuantasVezesOCaraDoisErrou { get; set; }

            private int NUMERO_MAXIMO_DE_ERROS = 3;

            private RoundPertencente RoundPertencente { get; set; }

            public void IniciaAPartida()
            {
                Console.WriteLine("Vez do player um!");
                Console.WriteLine("--------------------------");

                RoundPertencente = RoundPertencente.PertenceAPlayerUm;

                GeraPalavraParaAcertar();
            }

            private void ExecutaRound()
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("PROXIMO ROUND!");
                Console.WriteLine("--------------------------");

                Thread.Sleep(1000);
                Console.Clear();

                GeraPalavraParaAcertar();
            }
            private void MudaORoundParaOProximo()
            {
                if(RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                {
                    RoundPertencente = RoundPertencente.PertenceAPlayerDois;

                    Console.WriteLine("Vez do player dois");
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    RoundPertencente = RoundPertencente.PertenceAPlayerUm;

                    Console.WriteLine("Vez do player um");
                    Console.WriteLine("--------------------------");
                }

                Thread.Sleep(2000);
                Console.Clear();
            }

            private void AumentaPontuacao()
            {
                if(RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                {
                    PontuacaoCaraUm++;
                }
                else
                {
                    PontuacaoCaraDois++;
                }

                MostraAPontuacao();
            }

            private void MostraAPontuacao()
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pontuação atual:");
                Console.WriteLine($"Player um: {PontuacaoCaraUm}");
                Console.WriteLine($"Player dois: {PontuacaoCaraDois}");
                Console.WriteLine("------------------------------------");

                Console.WriteLine(".");
                Thread.Sleep(3000);
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);

                Console.Clear();
            }

            private void MostraPontuacaoComErro()
            {
                Console.WriteLine("Você errou, tome cuidado, você so pode errar 3X");
                
                if(RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                {
                    Console.WriteLine($"Vezes que voce errou player um: {QuantasVezesOCaraUmErrou}");
                }
                else
                {
                    Console.WriteLine($"Vezes que voce errou player dois: {QuantasVezesOCaraDoisErrou}");
                }

                MostraAPontuacao();
            }

            private void MostraPontuacaoFinal()
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pontuação final:");
                Console.WriteLine($"Player um: {PontuacaoCaraUm}");
                Console.WriteLine($"Player um: {PontuacaoCaraDois}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("O PLAYER GANHADOR É: O");

                if (PontuacaoCaraUm > PontuacaoCaraDois)
                    Console.WriteLine("UM!!!!!!!!!!!");
                else
                    Console.WriteLine("DOIS!!!!!!!!!!!!!!");
                Console.WriteLine("------------------------------------");

                Console.WriteLine(".");
                Thread.Sleep(3000);
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);

                Console.Clear();
            }

            private void EncerraOGame()
            {
                MostraPontuacaoFinal();

                Console.WriteLine("O game sera encerrado");

                Thread.Sleep(3000);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Obrigado por jogar!");
            }

            private void GeraPalavraParaAcertar()
            {
                var posicaoNoArray = new Random().Next(0, PalavrasPermitidas.Count - 1);
                var palavraAApareceNoConsole = PalavrasPermitidas[posicaoNoArray];
                var quantasLetrasTemEssaPalavra = palavraAApareceNoConsole.Length;

                Console.WriteLine(palavraAApareceNoConsole);
                Console.WriteLine("---------------------------");
                if(RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                    Console.WriteLine("PLAYER UM");
                else
                    Console.WriteLine("PLAYER DOIS");

                Console.WriteLine("Digite em número quantas letras essa palavra tem");
                Console.WriteLine("---------------------------");

                var numeroDigitado = Console.ReadLine();

                var ehUmNumeroValido = int.TryParse(numeroDigitado, out int numeroFormatado);

                if(ehUmNumeroValido)
                {
                    ExecutaProcessDeTrocaDeRoundOuFinalizacao(numeroFormatado, quantasLetrasTemEssaPalavra);                 
                }
                else //Nao eh um numero valido
                {
                    var numeroFinalmenteValido = DigitouUmaPalavraInvalida(numeroDigitado);

                    ExecutaProcessDeTrocaDeRoundOuFinalizacao(numeroFinalmenteValido, quantasLetrasTemEssaPalavra);
                }
            }

            private void ExecutaProcessDeTrocaDeRoundOuFinalizacao(int numeroFormatado, int quantasLetrasTemEssaPalavra)
            {
                if (numeroFormatado == quantasLetrasTemEssaPalavra)
                {
                    AumentaPontuacao();
                    MudaORoundParaOProximo();
                    ExecutaRound();
                }
                else
                {
                    if (RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                        QuantasVezesOCaraUmErrou++;
                    else
                        QuantasVezesOCaraDoisErrou++;

                    if (VerificaSeOPlayerErrouOMaximoQuePodia())
                    {
                        EncerraOGame();
                    }
                    else
                    {
                        MostraPontuacaoComErro();
                        MudaORoundParaOProximo();
                        ExecutaRound();
                    }
                }
            }

            private int DigitouUmaPalavraInvalida(string palavra)
            {
                var ehUmNumeroValido = int.TryParse(palavra, out int numeroFormatado);

                while(!ehUmNumeroValido)
                {
                    Console.WriteLine("Numero invalido, digite um número válido");
                    Console.Write("Quantidade de letras:");
                    var numeroDigitado = Console.ReadLine();

                    ehUmNumeroValido = int.TryParse(numeroDigitado, out numeroFormatado);
                }

                return numeroFormatado;
            }

            private bool VerificaSeOPlayerErrouOMaximoQuePodia()
            {
                if(RoundPertencente == RoundPertencente.PertenceAPlayerUm)
                {
                    if(QuantasVezesOCaraUmErrou >= NUMERO_MAXIMO_DE_ERROS)
                    {
                        Console.Write("O player um perdeu!");
                        Console.Write("O player dois ganhou!");

                        return true;
                    }

                    return false;
                }

                if(RoundPertencente == RoundPertencente.PertenceAPlayerDois)
                {
                    if(QuantasVezesOCaraDoisErrou >= NUMERO_MAXIMO_DE_ERROS)
                    {
                        Console.WriteLine("O player dois perdeu!");
                        Console.WriteLine("O player um ganhou!");

                        return true;
                    }

                    return false;
                }

                return false;
            }
        }

        enum RoundPertencente 
        { 
            PertenceAPlayerUm,
            PertenceAPlayerDois
        }

        static void Main(string[] args)
        {
            new JogoDeExemplo().IniciaAPartida();
        }
    }
}
