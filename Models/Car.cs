
using System.ComponentModel.DataAnnotations;

namespace gregslist_mysql.Models
{
  public class Car
  {
    public int Id { get; set; }
    [Required]
    public int Price { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
  }
}