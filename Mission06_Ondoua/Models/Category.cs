namespace Mission06_Ondoua.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
