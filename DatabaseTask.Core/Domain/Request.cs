using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        // FK
        public required int WorkTopicId { get; set; }
        public required WorkTopic WorkTopic { get; set; }

        // FK
        public int CreatorEmployeeId { get; set; }
        public required Employee Creator { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public required string Status { get; set; }
        public required string Description { get; set; }
    }
}
