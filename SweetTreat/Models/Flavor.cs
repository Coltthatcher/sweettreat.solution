using System.Collections.Generic;

namespace SweetTreat.Models
{
  public class Flavor 
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorType { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}