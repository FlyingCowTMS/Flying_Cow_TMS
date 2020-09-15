using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Flying_Cow_TMS.Roles.Dto;
using Flying_Cow_TMS.Users.Dto;

namespace Flying_Cow_TMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
