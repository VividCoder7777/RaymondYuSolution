using Abp.Application.Services.Dto;

namespace RaymondYuSolution.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

