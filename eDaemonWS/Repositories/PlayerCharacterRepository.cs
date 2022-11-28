using eDaemonWS.Data;
using eDaemonWS.Model.Characters;
using eDaemonWS.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace eDaemonWS.Repositories
{
    public class PlayerCharacterRepository : IPlayerCharacterRepository
    {
        private readonly PlayerCharacterDbContext _dbContext;

        public PlayerCharacterRepository(PlayerCharacterDbContext characterDbContext)
        {
            _dbContext = characterDbContext;
        }

        public async Task<PlayerCharacter> AddPlayerCharacterAsync(PlayerCharacter playerCharacter)
        {
            await _dbContext.PlayerCharacters.AddAsync(playerCharacter);
            await _dbContext.SaveChangesAsync();

            return playerCharacter;
        }

        public async Task<List<PlayerCharacter>> GetAllPlayerCharactersAsync()
        {
            return await _dbContext.PlayerCharacters.ToListAsync();
        }

        public async Task<PlayerCharacter> GetPlayerCharacterAsync(byte id)
        {
            return await _dbContext.PlayerCharacters.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PlayerCharacter> UpdatePlayerCharacterAsync(PlayerCharacter playerCharacter, byte id)
        {
            PlayerCharacter foundPlayerCharacter = await GetPlayerCharacterAsync(id);

            if (foundPlayerCharacter == null)
            {
                throw new Exception($"No player character was found with id {id}");
            }

            _dbContext.PlayerCharacters.Update(playerCharacter);
            await _dbContext.SaveChangesAsync();

            return playerCharacter;
        }

        public async Task<bool> RemovePlayerCharacterAsync(byte id)
        {
            PlayerCharacter foundPlayerCharacter = await GetPlayerCharacterAsync(id);

            if (foundPlayerCharacter == null)
            {
                throw new Exception($"No player character was found with id {id}");
            }

            _dbContext.PlayerCharacters.Remove(foundPlayerCharacter);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
