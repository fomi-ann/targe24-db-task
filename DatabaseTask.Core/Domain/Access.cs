using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Access
    {
        [Key]
        public int Id { get; set; }
        public required string Description { get; set; }

        public ICollection<Position> Positions { get; set; } = new List<Position>();
    }
}
