using System;
using System.ComponentModel.DataAnnotations;

namespace Schaken.Data
{
    public class Contestent
    {
        public int Id { get; set; }

        [Required]
        public int TournementId { get; set; }

        [Required]
        public int AspNetUsersId { get; set; }

        [Required]
        public DateTime EnlistTime { get; set; }
    }
}