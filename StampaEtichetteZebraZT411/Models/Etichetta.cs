using System;

namespace StampaEtichetteZebraZT411.Models
{
    public class Etichetta
    {
        public int Id { get; set; }
        public string NomeEtichetta { get; set; }
        public string CodiceCorrispondente { get; set; }
        public string Stagione { get; set; }
        public string Tipologia { get; set; }
        public string Barcode { get; set; }
        public string Genere { get; set; }
        public string PrezzoVendita { get; set; }
        public string NumeroEtichette { get; set; }
        // New fields introduced in the updated etichette.json
        public string NomeVisibileInCmbEtichetta { get; set; }
        public string Categoria { get; set; }
        //public string NomeTemplate { get; set; }
    }
}
