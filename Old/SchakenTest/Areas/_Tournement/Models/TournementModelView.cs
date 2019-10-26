using Schaken.Data.ValidationAttributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Areas._Tournement.Models
{
    public class TournementModelView
    {
        public int Id { get; set; }

        [DefaultValue("Tournement Name")]
        [Display(Name = "Tournement Name")]
        [Required, StringLength(40,MinimumLength = 6)]
        public string Name { get; set; }

        [VanafOverTienDagen]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{dd-MM-YYYY}", ApplyFormatInEditMode = true)]

        public DateTime? RegistrationStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? RegistrationEndDate { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime TournementStartDate { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.DateTime)]
        public DateTime TournementEndDate { get; set; }
    }
}