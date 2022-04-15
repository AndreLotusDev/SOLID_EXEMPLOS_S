namespace RESPEITANDO_O_SOLID.Class
{
    public static class ControladorDeRound
    {
        public static Rodada RodadaDeQuem { get; set; }

        public static string InformaDeQualPlayerEhARodada()
        {
            var ehRodadaDoPlayerUm = RodadaDeQuem == Rodada.RodadaPlayerUm;

            if (ehRodadaDoPlayerUm)
            {
                return "P1";
            }

            if (!ehRodadaDoPlayerUm)
            {
                return "P2";
            }

            return string.Empty;
        }
        
        public static void MudaARodadaParaOProximo()
        {
            var ehRodadaDoPlayerUm = RodadaDeQuem == Rodada.RodadaPlayerUm;

            if(ehRodadaDoPlayerUm)
            {
                RodadaDeQuem = Rodada.RodadaPlayerDois;
            }

            if (!ehRodadaDoPlayerUm)
            {
                RodadaDeQuem = Rodada.RodadaPlayerUm;
            }
        }
    }

    public enum Rodada
    {
        RodadaPlayerUm,
        RodadaPlayerDois
    }
}
