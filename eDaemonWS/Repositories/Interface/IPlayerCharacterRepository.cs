using eDaemonWS.Model.Characters;

namespace eDaemonWS.Repositories.Interface
{
    public interface IPlayerCharacterRepository
    {
        Task<List<PlayerCharacter>> GetAllPlayerCharactersAsync();
        Task<PlayerCharacter> GetPlayerCharacterAsync(byte id);
        Task<PlayerCharacter> AddPlayerCharacterAsync(PlayerCharacter playerCharacter);
        Task<PlayerCharacter> UpdatePlayerCharacterAsync(PlayerCharacter playerCharacter, byte id);
        Task<bool> RemovePlayerCharacterAsync(byte id);
    }
}
