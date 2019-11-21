using Microsoft.EntityFrameworkCore;
using SchaakData;
using System;
using System.Threading.Tasks;

namespace Schaak.Areas.Admin.Models
{
    public class TournementViewModel:Tournement
    {
        public static async Task<TournementViewModel> GetWithId(ApplContext _context, int? id)
        {
            var tournement = await _context.Tournement.FindAsync(id);
            TournementViewModel tournementViewModel = new TournementViewModel()
            {
                Id = tournement.Id,
                Name = tournement.Name,
                RegistrationStartDate = tournement.TournementStartDate
            };
            return tournementViewModel;
        }

        public static TournementViewModel GetWithTournementModel(Tournement tournement)
        {
            TournementViewModel tournementViewModel = new TournementViewModel()
            {
                Id = tournement.Id,
                Name = tournement.Name,
                RegistrationStartDate = tournement.TournementStartDate
            };
            return tournementViewModel;
        }

        public override int Id { get; set; }

        public override string Name { get; set; }

        public override DateTime? RegistrationStartDate { get; set; }

    }
}
