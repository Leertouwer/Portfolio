using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Data
{
    public class TournementModelRegistration
    {

        public int Id { get; set; }

        [Required]
        [Display(Name="Tournement Name")]
        public string Name { get; set; }

        public DateTime? RegistrationStartDate { get; set; }

        public DateTime? RegistrationEndDate { get; set; }
    }
}