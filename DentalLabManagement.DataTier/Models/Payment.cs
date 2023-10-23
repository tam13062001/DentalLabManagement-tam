﻿using System;
using System.Collections.Generic;

namespace DentalLabManagement.DataTier.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Note { get; set; } = null!;
        public string Type { get; set; } = null!;
        public double Amount { get; set; }
        public string Status { get; set; } = null!;

        public virtual Order Order { get; set; } = null!;
    }
}
