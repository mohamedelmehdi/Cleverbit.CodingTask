using Cleverbit.CodingTask.Data;
using System;
using Cleverbit.CodingTask.Data.Models;
using Cleverbit.Services.MatchSevice;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cleverbit.Services.MatchService
{
    public class MatchService : IMatchService
    {
        private readonly CodingTaskContext _context;
        public MatchService(CodingTaskContext context)
        {
            _context = context;
        }

        public int RegisterUser(int userid, int matchid)
        {
            try
            {
                _context.Database.BeginTransaction();
                MatchRegistration addedmatch = _context.Set<MatchRegistration>().Add(new MatchRegistration { UserId = userid, MatchId = matchid}).Entity;
                _context.SaveChanges();
                _context.Database.CommitTransaction();
                return addedmatch.Id;

            }
            catch
            {
                _context.Database.RollbackTransaction();
                throw;
            }
        }
        public List<object> ListUserRegistrations()
        {
            try
            {
                var res = _context.MatchRegistrations.Include(q => q.Match).Include(q => q.Winner);
                return res.Select(x => new { Winner = x.Winner.UserName, Match = x.MatchId, Date = x.Match.ExpireDate})
                    .OrderBy(k => k.Date).ToList<object>();

            }
            catch
            {
                throw;
            }
        }

        public void RemoveUserRegistration(int userid, int matchid)
        {
            try
            {
                _context.Database.BeginTransaction();
                var reg = _context.MatchRegistrations.FirstOrDefault(x => x.UserId == userid && x.MatchId == matchid);
                _context.MatchRegistrations
                    .Remove(reg);
                _context.SaveChanges();
                _context.Database.CommitTransaction();
            }
            catch
            {
                _context.Database.RollbackTransaction();
                throw;
            }
        }
    }
}
