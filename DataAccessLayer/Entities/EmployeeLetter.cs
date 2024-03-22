using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class EmployeeLetter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]       
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Recipient { get; set; }

        [Required]
        [StringLength(100)]
        public string Sender { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

    }
}
