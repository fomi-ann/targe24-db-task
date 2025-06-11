using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Address
{
    public int Id { get; set; }

    public string County { get; set; } = null!;

    public string CityDistrict { get; set; } = null!;

    public string AdministrativeUnit { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string BuildingNumber { get; set; } = null!;

    public int ApartmentNumber { get; set; }

    public int PostalCode { get; set; }

    public virtual ICollection<Employee1> Employee1s { get; set; } = new List<Employee1>();
}
