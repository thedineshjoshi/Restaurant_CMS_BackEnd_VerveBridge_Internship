﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contact
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string PhoneNumber {get; set; }
        public string Address { get; set; }
        public string Email {get; set; }
        
    }
}
