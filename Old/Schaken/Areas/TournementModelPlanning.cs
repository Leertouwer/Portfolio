using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Data
{
    public class TournementModelPlanning
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime TournementStartDate { get; set; }

        public DateTime TournementEndDate { get; set; }
    }
}