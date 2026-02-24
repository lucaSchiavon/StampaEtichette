using System;
using System.IO;
using Newtonsoft.Json;
using StampaEtichetteZebraZT411.Models;

namespace StampaEtichetteZebraZT411.Services
{
    public class ConfigurazioniService
    {
        private readonly string _path;
        public ConfigurazioniService(string path = "Configurazioni.json")
        {
            _path = path;
        }

        public Configurazioni Load()
        {
            if (!File.Exists(_path))
            {
                throw new FileNotFoundException("Il file di configurazione non esiste. Creare un file Configurazioni.json con i parametri necessari.");
                //var def = new Configurazioni { IndirizzoIPStampante = "127.0.0.1", NomeStampante = "ZDesigner ZD411-203dpi ZPL", PortaStampante = 58556 };
                //Save(def);
                //return def;
            }
            var txt = File.ReadAllText(_path);
            try
            {
                var conf = JsonConvert.DeserializeObject<Configurazioni>(txt);
                if (conf != null) return conf;
            }
            catch
            {
                // fall through to repair attempt
            }

            // attempt simple repairs for non-standard JSON (e.g. True/False capitalization)
            try
            {
                var repaired = txt.Replace(": True", ": true").Replace(": False", ": false")
                                  .Replace("\"True\"", "\"true\"").Replace("\"False\"", "\"false\"");
                var conf = JsonConvert.DeserializeObject<Configurazioni>(repaired);
                if (conf != null) return conf;
            }
            catch
            {
                // ignore and return defaults below
            }

            return new Configurazioni { IndirizzoIPStampante = "127.0.0.1", NomeStampante = "", PortaStampante = 58556, StampaViaTCPIP = true, StampaViaSpoolerWin = false };
        }

        //public void Save(Configurazioni conf)
        //{
        //    // write simple json
        //    var txt = "{\n" +
        //              $"  \"IndirizzoIPStampante\": \"{conf.IndirizzoIPStampante}\",\n" +
        //              $"  \"NomeStampante\": \"{conf.NomeStampante}\",\n" +
        //              $"  \"PortaStampante\": {conf.PortaStampante}\n" +
        //              "}\n";
        //    File.WriteAllText(_path, txt);
        //}
    }
}
