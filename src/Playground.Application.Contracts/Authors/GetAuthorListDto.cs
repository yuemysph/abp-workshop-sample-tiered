using Volo.Abp.Application.Dtos;
namespace Playground.Authors
{
    
        public class GetAuthorListDto : PagedAndSortedResultRequestDto
        {
            public string Filter { get; set; }
        }
    
}
