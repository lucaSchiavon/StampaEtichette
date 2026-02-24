using System;

namespace StampaEtichetteZebraZT411.Models
{
    public class Configurazioni
    {
        public string IndirizzoIPStampante { get; set; }
        public string NomeStampante { get; set; }
        public int PortaStampante { get; set; }
        // New configuration flags
        public bool StampaViaTCPIP { get; set; }
        public bool StampaViaSpoolerWin { get; set; }
    }
}
