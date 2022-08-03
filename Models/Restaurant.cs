using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DateOpened { get; set; }
    public virtual ICollection<CuisineRestaurant> JoinEntities { get;}

  }
}
