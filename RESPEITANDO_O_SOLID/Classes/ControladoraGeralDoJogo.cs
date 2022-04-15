namespace RESPEITANDO_O_SOLID.Class
{
    public static class ControladoraGeralDoJogo
    {
        public static void IniciaOJogo()
        {
            PrintaInformacaoNaTela.IndicaOInicioDaPartida();

            RodadaDeAcertarPalavra();
        }

        public static void RodadaDeAcertarPalavra()
        {
            var palavraSelecionada = DicionarioDePalavras.GeraPalavraRandomica();

            var palavraDigitadaPeloPlayer = PrintaInformacaoNaTela.GeraPalavraParaAcertar(palavraSelecionada);
            var ehValido = DicionarioDePalavras.VerificaSeEhUmNumeroValido(palavraDigitadaPeloPlayer);

            while(!ehValido)
            {
                palavraDigitadaPeloPlayer = PrintaInformacaoNaTela.PerguntaNovamenteProPlayerSobreAPalavra(palavraSelecionada);
                ehValido = DicionarioDePalavras.VerificaSeEhUmNumeroValido(palavraDigitadaPeloPlayer);
            }

            var acertou = DicionarioDePalavras.ComparaDuasPalavras(int.Parse(palavraDigitadaPeloPlayer), palavraSelecionada.Length);

            if (acertou)
            {
                PrintaInformacaoNaTela.Acertou();

                ControladorDePontuacao.AumentaPontuacao(); //Ele ja sabe de quem é o round de forma interna
                PrintaInformacaoNaTela.MostraPontuacao();
                ControladorDeRound.MudaARodadaParaOProximo();

                RodadaDeAcertarPalavra();
            }

            if(!acertou)
            {
                ControladorDePontuacao.SetaErroDoPlayer(); //Ja sabe qual é o player de forma interna
                PrintaInformacaoNaTela.Errou();

                var acabouAPartida = ControladorDePontuacao.DefineSeAPartidaAcabou();

                if(!acabouAPartida)
                {
                    ControladorDeRound.MudaARodadaParaOProximo();
                    ControladorDeRound.InformaDeQualPlayerEhARodada();

                    RodadaDeAcertarPalavra();
                }

                if(acabouAPartida)
                {
                    PrintaInformacaoNaTela.MostraPontuacaoEIndicaGanhador();
                    PrintaInformacaoNaTela.FinalizarAPartida();
                }
            }
        }
    }
}
