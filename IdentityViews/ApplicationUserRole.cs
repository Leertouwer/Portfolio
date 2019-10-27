using System;
using System.Linq;


namespace IdentityData
{
    public class ApplicationUserRole<Tkey>
    {
        private IdContext _context;

        public ApplicationUserRole() { }

        public ApplicationUserRole(IdContext context, Guid userId, Guid roleId)
        {
            _context = context;
            UserName = _context.Users.Where(u => u.Id == userId).Select(s => s.UserName).FirstOrDefault<string>();
            RoleName = _context.Roles.Where(r => r.Id == roleId).Select(s => s.Name).FirstOrDefault<string>();
        }

        public string UserName { get; set; }

        public string RoleName { get; set; }

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }
    }
}
