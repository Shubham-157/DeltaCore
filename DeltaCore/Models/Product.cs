using System.ComponentModel.DataAnnotations;

namespace DeltaCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;


    }
}
