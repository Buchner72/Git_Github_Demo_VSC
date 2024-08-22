using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VertragsLibrary;

namespace VertragslibraryToSqlDB.Service
{
    internal class VertragService : IVertragService
    {
        public TempVertrag? GetVertrag(int Id)
        {

            using var context = new VertragslibraryContext();
            // Angenommen 'Vertrag' ist der Entitätsname in Ihrem Kontext, der auf Verträge verweist
            var vertrag = context.Vertrag
                .Include(v => v.Fahrzeuge) // Bezieht Fahrzeuge ein, die zum Vertrag gehören
                .ThenInclude(f => f.ProduktdatenKFZ) // Bezieht ProduktdatenKFZ ein, die zu jedem Fahrzeug gehören
                .Include(v => v.Vertragsdaten) // Bezieht Vertragsdaten ein
                .Include(v => v.Versicherungsnehmer) // Bezieht Versicherungsnehmer ein
                .Include(v => v.Zahlungsdaten) // Bezieht Zahlungsdaten ein
                .Include(v => v.Inkassodaten) // Bezieht Inkassodaten ein
                .Include(v => v.Sachbearbeiter) // Bezieht Sachbearbeiter ein
                .FirstOrDefault(v => v.Id == Id); // Angenommen 'Id' ist der Primärschlüssel für Vertrag
          
            if (vertrag == null)
            {
                Console.WriteLine($"Kein Vertrag mit der Id= {Id} gefunden!");
            }

            return vertrag;
             
        }

        public void UpdateVertrag(TempVertrag vertrag)
        {
            ??????
        }
    }
}
