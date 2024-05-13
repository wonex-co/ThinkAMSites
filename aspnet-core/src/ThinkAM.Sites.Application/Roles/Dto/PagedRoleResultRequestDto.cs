using Abp.Application.Services.Dto;

namespace ThinkAM.Sites.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

