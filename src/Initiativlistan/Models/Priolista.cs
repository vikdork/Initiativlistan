using System;


namespace Initiativlistan.Models
{
    public class Priolista
    {
        public int ID { get; set; }
        public string ärendeägare { get; set; }
        public string beställare { get; set; }
        public string namnPåAktvivitet { get; set; }
        public string beskrivning { get; set; }
        public string förvaltning { get; set; }
        public string finnsIPlan { get; set; }
        public string typAvFörändring { get; set; }
        public bool akut { get; set; }
        public string beskrivAkut { get; set; }
        public string kategorisering { get; set; }
        public string nuvarandePåverkan { get; set; }
        public string framtidaPåverkan { get; set; }
        public DateTime önskatDatum { get; set; }
        public DateTime tidasram { get; set; }
        public string kostnader { get; set; }
        public string budget { get; set; }
        public string beroende { get; set; }
        public string verksamhetspåverkarn { get; set; }
    }
}
