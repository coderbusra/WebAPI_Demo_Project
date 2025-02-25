using System.ComponentModel.DataAnnotations;

namespace WebAPIDemoProject.Model
{
    public abstract class CommonClass
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
