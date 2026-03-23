using ImpulseClub.Entities;

namespace ImpulseClub.Repositories
{
    public interface ITrainingRepository
    {
        Task<IEnumerable<Training>> GetAll();
        Task<IEnumerable<Training>> GetAllAsync();
        Task<Training?> GetOne(Guid id);
        Task<Training?> GetByIdAsync(Guid id);
        Task<Training?> GetByIdWithParticipantsAsync(Guid id);
        Task<IEnumerable<Training>> GetByClubIdAsync(Guid clubId);
        Task AddAsync(Training training);
        Task UpdateAsync(Training training);
        Task DeleteAsync(Training training);
    }
}
