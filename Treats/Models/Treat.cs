using System.Collections.Generic;
using System; 
using System.ComponentModel.DataAnnotations;

namespace Treats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }    
    public string Name{ get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set ;}
  }
}