using System;
using System.ComponentModel.DataAnnotations;

namespace SchaakData
{
    public class Contestent
    {
        public Contestent() => EnlistDate = DateTime.Now;

        [Key]
        public virtual int Id { get; set; }

        [Required]
        public virtual int TournementId { get; set; }

        [Required]
        public virtual string UsersId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Tournement Registration Date")]

        public virtual DateTime EnlistDate { get; set; }
    }
}