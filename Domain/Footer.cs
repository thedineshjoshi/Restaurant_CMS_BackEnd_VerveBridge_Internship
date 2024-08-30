﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FooterBottom
    {
        public Guid id { get; set; }
        public string CompanyInfo { get; set; }
        public string ContactInfo { get; set; }
        public List<SocialLink> SocialLinks { get; set; }
        public string NewsletterText { get; set; }
    }

}
