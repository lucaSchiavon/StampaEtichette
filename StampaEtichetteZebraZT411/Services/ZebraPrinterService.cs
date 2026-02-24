using System;
using System.IO;
using System.Net.Sockets;
using System.Globalization;
using System.Linq;
using StampaEtichetteZebraZT411.Models;

namespace StampaEtichetteZebraZT411.Services
{
    public class ZebraPrinterService
    {
        private readonly Configurazioni _conf;

        public ZebraPrinterService(Configurazioni conf)
        {
            _conf = conf;
        }

        public string PreparaTemplate(string pathTemplate, Etichetta e, string prezzo, string numero)
        {
            var template = File.ReadAllText(pathTemplate);
            // build barcode that embeds the price in the last 4 characters
            string barcodeValue = BuildBarcodeWithPrice(e?.Barcode, prezzo);

            var result = template.Replace("{{BARCODE}}", barcodeValue)
                                 .Replace("{{TIPOLOGIA}}", e != null ? e.Tipologia ?? string.Empty : string.Empty)
                                 .Replace("{{CATEGORIA}}", e != null ? e.Categoria ?? string.Empty : string.Empty)
                                 .Replace("{{PREZZOVENDITA}}", prezzo ?? string.Empty)
                                 .Replace("{{NUMEROETICHETTE}}", numero ?? string.Empty);

            return result;
        }

        private static string BuildBarcodeWithPrice(string baseBarcode, string prezzo)
        {
            if (string.IsNullOrEmpty(baseBarcode)) return string.Empty;
            if (string.IsNullOrWhiteSpace(prezzo)) return baseBarcode;

            // clean prezzo string: keep digits and separators
            var cleaned = new string(prezzo.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());
            if (string.IsNullOrEmpty(cleaned)) return baseBarcode;

            // normalize decimal separator to '.'
            cleaned = cleaned.Replace(',', '.');

            if (!decimal.TryParse(cleaned, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal val))
            {
                return baseBarcode;
            }

            // convert to cents (integer)
            var cents = (int)Math.Round(val * 100M);
            // ensure four digits, take modulo 100000 if too large

            var centsStr = (cents % 100000).ToString("D5");

            if (baseBarcode.Length >= 5)
            {
                return baseBarcode.Substring(0, baseBarcode.Length - 5) + centsStr;
            }

            // if base shorter than 4, append cents
            return baseBarcode + centsStr;
        }

        public void Stampa(string contenuto)
        {
            if (!string.IsNullOrEmpty(_conf?.IndirizzoIPStampante))
            {
                using (var client = new TcpClient())
                {
                    client.Connect(_conf.IndirizzoIPStampante, _conf.PortaStampante);
                    using (var stream = client.GetStream())
                    {
                        var buffer = System.Text.Encoding.UTF8.GetBytes(contenuto);
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(_conf?.NomeStampante))
            {
                RawPrinterHelper.SendStringToPrinter(_conf.NomeStampante, contenuto);
            }
            else
            {
                throw new InvalidOperationException("Nessuna configurazione stampante valida");
            }
        }
    }
}
