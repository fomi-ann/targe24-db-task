using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public required string County { get; set; }
        public required string CityDistrict { get; set; }
        public required string AdministrativeUnit { get; set; }
        public required string StreetName { get; set; }
        public required string BuildingNumber { get; set; }
        public required int ApartmentNumber { get; set; }
        public required int PostalCode { get; set; }

    }
}
