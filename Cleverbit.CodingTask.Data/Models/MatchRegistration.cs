using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cleverbit.CodingTask.Data.Models
{
    public class MatchRegistration
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        [ForeignKey(nameof(MatchId))] public Match Match { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))] public User Winner { get; set; }
    }
}
