using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Data
{
    public class TournementModelCreate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a tournement name")]
        //[Display(Name = "Tournement Name", Description = "descr tour", Prompt = "tourprompt", GroupName = "TourGroupName")]
        [Display(Name = "Tournement Name")]


        public string Name { get; set; }

        public DateTime TournementStartDate { get; set; }

        public DateTime TournementEndDate { get; set; }

        public DateTime? RegistrationStartDate { get; set; }

        public DateTime? RegistrationEndDate { get; set; }
    }
}