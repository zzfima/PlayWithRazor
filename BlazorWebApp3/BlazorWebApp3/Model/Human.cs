using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp1.Model
{
    public class Human
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Weight { get; set; }
    }
}
