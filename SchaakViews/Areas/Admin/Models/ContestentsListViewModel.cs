using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchaakData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using IdentityData;

namespace Schaak.Areas.Admin.Models
{
    public class ContestentsListViewModel:Contestent
    {
        public ContestentsListViewModel(Contestent c, string userName, string userID, Tournement t)
        {
            ContestentId = c.Id;
            UserName = userName;
            EnlistDate = c.EnlistDate;
            TournementName = t.Name;
            RegistrationStartDate = t.RegistrationStartDate;
            RegistrationEndDate = t.RegistrationEndDate;
            TournementStartDate = t.TournementStartDate;
            TournementEndDate = t.TournementEndDate;
            TournementId = t.Id;
            UsersId = userID;
        }

        public ContestentsListViewModel()
        { }

        public ContestentsListViewModel(ApplContext appContext, IdContext idContext, int? id)
        {
            IQueryable a = (from c in appContext.Contestent
                            join u in idContext.Users
                            on c.UsersId equals u.Id.ToString()
                            join t in appContext.Tournement.AsNoTracking()
                            on c.TournementId equals t.Id
                            where (c.Id == id)
                            select new
                            {
                                ContestentId = c.Id,
                                c.EnlistDate,
                                c.UsersId,
                                t.RegistrationEndDate,
                                t.RegistrationStartDate,
                                t.TournementEndDate,
                                t.TournementStartDate,
                                TournementName = t.Name,
                                c.TournementId
                            });
            IQueryable<ContestentsListViewModel> b = from u in idContext.Users.AsNoTracking()
                                                 join c in appContext.Contestent.AsNoTracking()
                                                 on u.Id.ToString() equals c.UsersId
                                                 join t in appContext.Tournement.AsNoTracking()
                                                 on c.TournementId equals t.Id
                                                 where c.Id == id
                                                 select new ContestentsListViewModel()
                                                 {
                                                     ContestentId = c.Id,
                                                     EnlistDate = c.EnlistDate,
                                                     UsersId = c.UsersId,
                                                     RegistrationEndDate = t.RegistrationEndDate,
                                                     RegistrationStartDate = t.RegistrationStartDate,
                                                     TournementEndDate = t.TournementEndDate,
                                                     TournementStartDate = t.TournementStartDate,
                                                     TournementName = t.Name,
                                                     TournementId = c.TournementId
                                                 };
            ContestentsListViewModel d = appContext.Contestent
                .Where(q => q.Id == id)
                .Join(idContext.Users, contestent => contestent.UsersId.ToString(), users => users.Id.ToString(), (contestent, users) => new
                {
                    contestent.UsersId,
                    contestent.EnlistDate,
                    ContestentId = contestent.Id,
                    contestent.TournementId,
                    users.UserName
                })
            .Join(appContext.Tournement, contestuser => contestuser.TournementId, tournement => tournement.Id, (contestuser, tournement) => new ContestentsListViewModel()
            {
                UsersId = contestuser.UsersId,
                EnlistDate = contestuser.EnlistDate,
                ContestentId = contestuser.ContestentId,
                TournementId = contestuser.TournementId,
                UserName = contestuser.UserName,
                TournementName = tournement.Name,
                RegistrationStartDate = tournement.RegistrationStartDate,
                RegistrationEndDate = tournement.RegistrationEndDate,
                TournementStartDate = tournement.TournementStartDate,
                TournementEndDate = tournement.TournementEndDate
            })
            .First<ContestentsListViewModel>();

            ContestentsListViewModel e = a.Cast<ContestentsListViewModel>().First();

            this.RegistrationEndDate = e.RegistrationEndDate;
            this.UsersId = e.UsersId;
            this.ContestentId = e.ContestentId;
            this.EnlistDate = e.EnlistDate;
            this.RegistrationStartDate = e.RegistrationStartDate;
            this.TournementEndDate = e.TournementEndDate;
            this.TournementId = e.TournementId;
            this.TournementName = e.TournementName;
            this.TournementStartDate = e.TournementStartDate;
        }
       
        public int ContestentId { get; set; }

        [Display(Name = "Inschrijf Datum")]
        [DataType(DataType.Date)]

        public string UserName { get; set; }

        public string TournementName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RegistrationStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RegistrationEndDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime TournementStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime TournementEndDate { get; set; }
    }
}
