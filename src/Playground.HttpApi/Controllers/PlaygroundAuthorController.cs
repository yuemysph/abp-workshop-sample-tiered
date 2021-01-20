using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Playground.Authors;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Playground.Controllers
{
    [Route("api/app/authors")]
    public class PlaygroundAuthorController : AbpController, IAuthorAppService
    {
        protected IAuthorAppService AuthorAppService;

        public PlaygroundAuthorController(IAuthorAppService authorAppService)
        {
            AuthorAppService = authorAppService;
        }

        [HttpPost]
        public Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        {
            return AuthorAppService.CreateAsync(input);
        }

        [HttpDelete]
        public Task DeleteAsync(Guid id)
        {
            return AuthorAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<AuthorDto> GetAsync(Guid id)
        {
            return AuthorAppService.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input)
        {
            return AuthorAppService.GetListAsync(input);
        }

        [HttpPut]
        public Task UpdateAsync(Guid id, UpdateAuthorDto input)
        {
            return AuthorAppService.UpdateAsync(id, input);
        }
    }
}
