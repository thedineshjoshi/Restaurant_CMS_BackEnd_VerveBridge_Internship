using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chefs
{
    public class TeamMember
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
    }
}
