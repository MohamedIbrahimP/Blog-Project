using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blog_Project.Models
{
    public class post
    {
        [Key]
        public int id{ get; set; }
        public string title { get; set; }
        public string? bref{ get; set; }
        [DisplayName("Description")]
        public string? desc{ get; set; }
        public TimeSpan? time{ get; set; }
        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public byte[]? image{ get; set; }

        [DisplayName("Auther")]
        [ForeignKey("auther")]
        public int autherId{ get; set; }
        public virtual Auther auther { get; set; }
        [DisplayName("Category")]
        [ForeignKey("category")]
        public int categoryId { get; set; }
        public virtual Category category{ get; set; }




    }
}
