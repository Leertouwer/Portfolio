using System;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Data
{
    public class Tournement
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? RegistrationStartDate { get; set; }

        public DateTime? RegistrationEndDate { get; set; }

        public DateTime TournementStartDate { get; set; }

        public DateTime TournementEndDate { get; set; }
    }
}