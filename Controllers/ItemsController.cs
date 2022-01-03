using System.Collections.Generic;
using System.Linq;
using Catalog.Dto;
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
        public IEnumerable<ItemDto> GetItems(){
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id){
            var item = repository.GetItem(id);

            if(item == null){
                return NotFound();
            }
            return item.AsDto();
        }

    
        // POST /items
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            Item item = new(){
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };

            repository.CreateItem(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id}, item.AsDto());
        }
        
    }

}