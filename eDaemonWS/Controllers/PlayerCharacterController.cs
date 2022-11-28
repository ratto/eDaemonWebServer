using eDaemonWS.Model.Characters;
using eDaemonWS.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eDaemonWS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PlayerCharacterController : ControllerBase
    {
        private readonly IPlayerCharacterRepository _repository;

        public PlayerCharacterController(IPlayerCharacterRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlayerCharacter>>> GetAllPlayerCharacters()
        {
            List<PlayerCharacter> result = await _repository.GetAllPlayerCharactersAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerCharacter>> GetPlayerCharacter(byte id)
        {
            PlayerCharacter result = await _repository.GetPlayerCharacterAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<PlayerCharacter>> AddPlayerCharacter([FromBody] PlayerCharacter playerCharacter)
        {
            PlayerCharacter result = await _repository.AddPlayerCharacterAsync(playerCharacter);

            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<PlayerCharacter>> UpdatePlayerCharacter([FromBody] PlayerCharacter playerCharacter, byte id)
        {
            playerCharacter.Id = id;
            PlayerCharacter result = await _repository.UpdatePlayerCharacterAsync(playerCharacter, id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> RemovePlayerCharacter(byte id)
        {
            bool result = await _repository.RemovePlayerCharacterAsync(id);

            return Ok(result);
        }
    }
}
