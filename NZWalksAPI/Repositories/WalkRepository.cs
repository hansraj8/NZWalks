using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Data;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public WalkRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public Task<Walk> AddAsync(Walk walk)
        {
            throw new NotImplementedException();
        }

        public Task<Walk> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Walk>> GetAllAsync()
        {
         return await nZWalksDbContext.Walks.ToListAsync();
        }

        public async Task<Walk> GetAsync(Guid id)
        {
           return await nZWalksDbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Walk> UpdateAsync(Guid id, Walk walk)
        {
            throw new NotImplementedException();
        }
    }
}
