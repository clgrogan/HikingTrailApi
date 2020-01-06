

namespace HikingTrailApi.Models
{
  public class Trail
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int Length { get; set; }
    public string Grade { get; set; }

    // ParkId is the foreign Key and the 
    // Park is the reference to the record in Park
    public int ParkId { get; set; }
    public Park Park { get; set; }
  }

}