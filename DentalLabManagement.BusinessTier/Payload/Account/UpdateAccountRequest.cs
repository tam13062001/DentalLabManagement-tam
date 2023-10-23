﻿using DentalLabManagement.BusinessTier.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLabManagement.BusinessTier.Payload.Account
{
    public class UpdateAccountRequest
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        [EnumDataType(typeof(AccountStatus))]
        public AccountStatus Status { get; set; }
    }
}
