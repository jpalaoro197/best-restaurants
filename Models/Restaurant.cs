namespace BestRestaurants.Models
{
  public class Restaurant
  {
        public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }

    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}
