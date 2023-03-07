using API.Data.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetAllAsync();
        Task<AppUser> GetByIdAsync(int id);
        Task<AppUser> GetByUsernameAsync(string username);
        
        Task<IEnumerable<MemberDTO>> GetAllMembersAsync();
        Task<MemberDTO> GetMemberByUsernameAsync(string username);

        Task<bool> SaveAllAsync();
    }
}
