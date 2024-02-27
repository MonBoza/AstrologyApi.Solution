using System.ComponentModel.DataAnnotations;

namespace AstrologyApi.Models
{
  public class Sign
  {
    public int SignId { get; set; }
    [Required]
    public string SignName { get; set; }
    [Required]
    public string Expression { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Concentration { get; set; }
  }
}