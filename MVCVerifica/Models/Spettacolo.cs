using System.ComponentModel.DataAnnotations;

namespace MVCVerifica.Models {
    public class Spettacolo {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}
