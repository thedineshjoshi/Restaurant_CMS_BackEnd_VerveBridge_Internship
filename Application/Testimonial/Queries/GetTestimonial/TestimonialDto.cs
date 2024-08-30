﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Testimonial.Queries.GetTestimonial
{
    public class TestimonialDto
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}
