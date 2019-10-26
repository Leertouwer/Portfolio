using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace IdentityData
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ICollection<IdentityUserRole<Guid>> UserRoles { get; set; }
    }
}
