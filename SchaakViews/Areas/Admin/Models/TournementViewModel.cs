using SchaakData;
using SchaakData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schaak.Areas.Admin.Models
{
    public class TournementViewModel:Tournement
    {
        public override int Id { get; set; }


        public override string Name { get; set; }


        public override DateTime? RegistrationStartDate { get; set; }


    }
}
