using System;

namespace RollmaterialVerwaltung.Models
{
    public class Locomotive
    {
        public Guid Id { get; set; }
        //Kaufpreis   	Verkäufer	Schätzpreis	Hersteller	Art.Nr	Set Nr.	Bezeichnung	Bemerkung	Bahngesellschaft	Loktyp	Loknummer	Veröffentlichung 	Bemerkungen

        public DateTime YearOfOwnership { get; set; }
    }
}
