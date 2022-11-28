using eDaemonWS.Model.General;

namespace eDaemonWS.Services.General.Interface
{
    public interface IDiceRollerService
    {
        public int RollDice(Dice dice, byte times, byte bonus);
    }
}
