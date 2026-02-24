using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using StampaEtichetteZebraZT411.Models;

namespace StampaEtichetteZebraZT411.Data
{
    public class EtichetteRepository
    {
        public IEnumerable<Etichetta> GetAll()
        {
            var file = "etichette.json";
            if (!File.Exists(file)) return new List<Etichetta>();

            var txt = File.ReadAllText(file, Encoding.UTF8);
            try
            {
                var list = JsonConvert.DeserializeObject<List<Etichetta>>(txt);
                return list ?? new List<Etichetta>();
            }
            catch
            {
                // fallback: try to repair common issues (e.g. trailing commas) or return empty
                try
                {
                    // a minimal repair: replace common wrong True/False capitalization
                    var repaired = txt.Replace("\"True\"", "\"true\"").Replace("\"False\"", "\"false\"")
                                      .Replace(" True", " true").Replace(" False", " false");
                    var list = JsonConvert.DeserializeObject<List<Etichetta>>(repaired);
                    return list ?? new List<Etichetta>();
                }
                catch
                {
                    return new List<Etichetta>();
                }
            }
        }

        public Etichetta GetById(int id)
        {
            foreach (var it in GetAll())
                if (it.Id == id) return it;
            return null;
        }

        // Parsing delegated to Newtonsoft.Json
    }
}
