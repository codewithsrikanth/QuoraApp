using System.ComponentModel.DataAnnotations;

namespace QuoraApp.ViewModels
{
    public class CategoryViewModel
    {
        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
