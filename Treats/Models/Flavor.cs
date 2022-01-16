using System.Collections.Generic;
using System; 
using System.ComponentModel.DataAnnotations;

namespace Treats.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntities = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FlavorTreat> JoinEntities { get;}
    }
}