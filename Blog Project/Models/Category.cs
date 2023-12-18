using System.ComponentModel.DataAnnotations;


namespace Blog_Project.Models
{
    public class Category
    {
        [Key]
        public int id{ get; set; }

        public string name{ get; set; }

        public string? desc { get; set; }
        

    }
}
