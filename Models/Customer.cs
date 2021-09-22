using System;
using System.Collections.Generic;

#nullable disable

namespace NewCore.Data.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}
