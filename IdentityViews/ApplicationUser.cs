using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Security;

namespace IdentityData
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser() : base()
        {
            SecurityStamp = Guid.NewGuid().ToString();
        }
       
        public ApplicationUser(string userName) : base(userName)
        {
            SecurityStamp = Guid.NewGuid().ToString();
        }

        public List<IdentityUserRole<Guid>> Roles { get; set; }

        [Display(Name ="Voornaam")]
        public string FirstName { get; set; }

        [Display(Name ="Achternaam")]
        public string LastName { get; set; }

        [Display(Name ="Administrator")]
        [NotMapped]
        public string DisplayName => $"{ this.FirstName } { this.LastName }";

        [NotMapped]
        public bool Admin { get; set; }

        [NotMapped]
        public Guid RoleId { get; set; }

        [NotMapped]
        public string RoleName { get; set; }
    }
}