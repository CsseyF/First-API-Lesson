using System.ComponentModel.DataAnnotations;
namespace Catalog.Dto{


    public class UpdateItemDto{

        [Required]
         public string Name {get; init;}
        [Required]
        [Range(1, 999999)]         
        public float Price {get; init;}
    }

}