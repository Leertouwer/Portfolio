using System;
using System.ComponentModel.DataAnnotations;

namespace SchaakData
{
    public class Tournement
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        [Display(Name = "Tournement Name")]
        public virtual string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Registration start date")]
        public virtual DateTime? RegistrationStartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Registration end date")]
        public virtual DateTime? RegistrationEndDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Planning start date")]
        public virtual DateTime TournementStartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Planning end date")]
        public virtual DateTime TournementEndDate { get; set; }
    }
}