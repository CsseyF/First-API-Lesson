using System.ComponentModel.DataAnnotations;
namespace Catalog.Dto{


    public class CreateItemDto{

        [Required]
         public string Name {get; init;}
        [Required]
        [Range(1, 999999)]         
        public float Price {get; init;}
    }

}