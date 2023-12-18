using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blog_Project.Models
{
    public class Auther
    {
        [Key]
        public int id{ get; set; }

        [DisplayName("Name")]
        [Column("Name")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password{ get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string confirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
        public int? age{ get; set; }

        public byte[]? image{ get; set; }




    }
}
