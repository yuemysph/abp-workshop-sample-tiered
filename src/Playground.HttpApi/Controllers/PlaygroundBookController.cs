using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Playground.Books;
using Playground.Localization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Playground.Controllers
{ 
    [Route("api/app/books")]
    public class PlaygroundBookController : AbpController
    {
        protected IBookAppService BookAppService;

        public PlaygroundBookController(IBookAppService bookAppService)
        {
            BookAppService = bookAppService;
        }
        [HttpPost]
        public Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            return BookAppService.CreateAsync(input);
        }
        [HttpDelete]
        public Task DeleteAsync(Guid id)
        {
            return BookAppService.DeleteAsync(id);
        }


        [HttpGet]
        [Route("{id}")]
        public Task<BookDto> GetAsync(Guid id)
        {
            return BookAppService.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return BookAppService.GetListAsync(input);
        }

        [HttpPut]
        public Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            return BookAppService.UpdateAsync(id, input);
        }
    }
}
