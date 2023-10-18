using System.ComponentModel.DataAnnotations;

namespace HaylandMontalvo_ProyectoTablas.Models
{
    public class Burgers
    {
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.1,30.00)]
        public decimal precio {get; set;}


  
    
    }
    }
}
