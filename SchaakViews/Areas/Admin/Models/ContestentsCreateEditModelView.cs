using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchaakData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;
using IdentityData;


namespace Schaak.Areas.Admin.Models
{
    public class ContestentsCreateEditModelView:Contestent
    {
        ApplContext _appContext;
        IdContext _idContext;
        readonly IServiceProvider _serviceProvider;
        readonly RoleManager<ApplicationRole> _roleManager;
        readonly UserManager<ApplicationUser> _userManager;

        public ContestentsCreateEditModelView(ApplContext appContext, IdContext idContext)
        {
            _appContext = appContext;
            _idContext = idContext;
            this.GetSelectListItems();
        }

        public ContestentsCreateEditModelView(IServiceProvider serviceProvider)
        {
            _appContext = serviceProvider.GetService<ApplContext>();
            _idContext = serviceProvider.GetService<IdContext>();
            _serviceProvider = serviceProvider;
            this.GetSelectListItems();
            _roleManager = serviceProvider.GetService<RoleManager<ApplicationRole>>();
            _userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
        }

        public void GetSelectListItems()
        {
            Tournments = _appContext.Tournement
             .Select(v => new SelectListItem()
             {
                 Text = v.Name,
                 Value = v.Id.ToString(),
                 Selected = TournementId.Equals(v.Id)
             });

            AspNetUsers = _idContext.Users
                .Select(u => new SelectListItem()
                {
                    Text = u.UserName,
                    Value = u.Id.ToString(),
                    Selected = u.Id.Equals(UsersId)
                });
        }

        public ContestentsCreateEditModelView(int? id)
        {
            this.GetSelectListItems();
            var contestent = _appContext.Contestent
                .Where(c => c.Id.Equals(id)).
                Select(v => new Contestent()
                {
                    Id = v.Id,
                    UsersId = v.UsersId,
                    TournementId=v.TournementId
                }).FirstOrDefault();
            this.Id = contestent.Id;
            this.UsersId = contestent.UsersId;
            this.TournementId = contestent.TournementId;
        }

        public IEnumerable<SelectListItem> AspNetUsers { get; set; }

        public IEnumerable<SelectListItem> Tournments { get; set; }
    }

}
