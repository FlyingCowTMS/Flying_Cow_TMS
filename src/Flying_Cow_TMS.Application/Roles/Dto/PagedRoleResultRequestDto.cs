using Abp.Application.Services.Dto;

namespace Flying_Cow_TMS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

