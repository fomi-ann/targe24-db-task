using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Devices
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string SerialNumber { get; set; }
        public required string Condition { get; set; }

        public ICollection<ObjectRent> ObjectGrants { get; set; } = new List<ObjectRent>();
    }
}
