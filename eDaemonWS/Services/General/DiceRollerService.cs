using eDaemonWS.Model.General;

namespace eDaemonWS.Services.General
{
    public class DiceRollerService
    {
        public DiceRollerService() { }

        public int RollDice(Dice dice, byte times, byte bonus)
        {
            int result = 0;

            for (int i = 0; i < times; i++)
            {
                result += (int)Math.Floor((decimal)Random.Shared.Next(1, dice.GetFaceNumber() + 1));
            }

            result += bonus;

            return result;
        }
    }
}
