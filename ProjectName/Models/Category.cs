using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryItem>();

      // this.JoinEntities2 = new HashSet<CategorySpecialty>();

    }

    public int CategoryId { get; set; }

    public string Name { get; set; }

    public string Specialty { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; set; }
  }
}
