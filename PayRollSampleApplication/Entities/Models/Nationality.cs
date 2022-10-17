using System;
using System.Collections.Generic;

namespace PayRollSampleApplication.Entities.Models
{
    public partial class Nationality
    {
        public int NationalityId { get; set; }
        public string Name { get; set; } = null!;
    }
}
