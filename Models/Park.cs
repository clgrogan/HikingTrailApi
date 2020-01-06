using System.Collections.Generic;

namespace HikingTrailApi.Models
{
  public class Park
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Description { get; set; }
    public string Designation { get; set; }

    // Foreign Key List used for all trail records associated with the Park
    public List<Trail> Trails { get; set; } = new List<Trail>();

  }

}