using System.Threading;

namespace RESPEITANDO_O_SOLID.Class
{
    public static class TemporizadorDaTela
    {
        public const int TEMPO_RAPIDO = 1000; // Quando quero ter um delay rapido
        public const int TEMPO_MEDIO = 2000; // Quando quero ter um delay medio
        public const int TEMPO_LONGO = 3000; // Quando quero ter um delay longo

        public static void DormirRapidamente()
        {
            Thread.Sleep(TEMPO_RAPIDO);
        }

        public static void DormirTempoMedio()
        {
            Thread.Sleep(TEMPO_MEDIO);
        }

        public static void DormirTempoLongo()
        {
            Thread.Sleep(TEMPO_LONGO);
        }
    }
}
