using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string ParkName { get; set; }
    [Required]
    public string Desination { get; set; }
    [Required]
    public string StatesCode { get; set; }
    [Required]
    public string Address { get; set; }
    public string Description { get; set; }
    public string Weather { get; set; }
    [Required]
    public string WebsiteUrl { get; set; }
  }
}    