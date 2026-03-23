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

        // BORRA Task Add(Training training);
        Task AddAsync(Training training);

        // BORRA Task Update(Training training);
        Task UpdateAsync(Training training);

        // BORRA Task Delete(Training training);
        Task DeleteAsync(Training training);
    }
}
