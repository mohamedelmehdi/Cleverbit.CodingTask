using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cleverbit.CodingTask.Data.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime ExpireDate { get; set; }
        #region Relations
        public int? UserId { get; set; }
        [ForeignKey(nameof(UserId))] public User Winner { get; set; }
        #endregion
    }
}
