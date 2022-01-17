using System.Collections.Generic;

namespace SweetTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatType { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}