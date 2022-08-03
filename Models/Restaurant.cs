using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime Date { get; set; }
    public virtual ICollection<CuisineRestaurant> JoinEntities { get;}

  }
}
