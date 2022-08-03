using System.Collections.Generic;

namespace UniversityRoster.Models
{
  public class Cuisine
    {
        public Cuisine()
        {
            this.JoinEntities = new HashSet<CuisineRestaurant>();
        }

        public int CuisineId { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<CuisineRestaurant> JoinEntities { get; set; }

    }
}