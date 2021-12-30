using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{


    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase{
        private readonly IItemsrespository repository;

        public ItemsController(IItemsrespository repository){
            this.repository = repository;
        }


        //GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems(){
            var items = repository.GetItems();
            return items;
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id){
            var item = repository.GetItem(id);

            if(item == null){
                return NotFound();
            }
            return item;
        }
    }

}