using System;
using System.ComponentModel.DataAnnotations;


namespace Initiativlistan.Models
{
    public class Priolista
    {
        public int ID { get; set; }
        [Display(Name ="Ärendeägare")]
        public string ärendeägare { get; set; }
        [Display(Name = "Beställare")]
        public string beställare { get; set; }
        [Display(Name = "Namn på aktivitet")]
        public string namnPåAktvivitet { get; set; }
        [Display(Name = "Beskrivning")]
        public string beskrivning { get; set; }
        [Display(Name = "Förvaltning?")]
        public string förvaltning { get; set; }
        [Display(Name = "Kryssa i om aktiviteten finns i en plan")]
        public string finnsIPlan { get; set; }
        [Display(Name = "Typ av förändring")]
        public string typAvFörändring { get; set; }
        [Display(Name = "Är ändringen akut?")]
        public bool akut { get; set; }
        [Display(Name = "Beskrivning av vad som är akut")]
        public string beskrivAkut { get; set; }
        [Display(Name = "Kategorisering")]
        public string kategorisering { get; set; }
        [Display(Name = "Nuvarande påverkan")]
        public string nuvarandePåverkan { get; set; }
        [Display(Name = "Framtida påverkan")]
        public string framtidaPåverkan { get; set; }
        [Display(Name = "Önskat datum för etablering")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime önskatDatum { get; set; }
        [Display(Name = "Tidsram")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime tidasram { get; set; }
        [Display(Name ="Kända kostnader förknippade med förändringen")]
        public string kostnader { get; set; }
        [Display(Name ="Budget för ändringen")]
        public string budget { get; set; }
        [Display(Name ="Eventuellt beroende till annat projekt")]
        public string beroende { get; set; }
        [Display(Name ="Verksamhetspåverkan")]
        public string verksamhetspåverkarn { get; set; }
    }
}