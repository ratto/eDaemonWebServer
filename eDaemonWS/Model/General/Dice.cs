using eDaemonWS.Model.General.Enum;

namespace eDaemonWS.Model.General
{
    public class Dice
    {
        public DiceType Type { get; }

        public Dice(DiceType type)
        {
            Type = type;
        }

        public byte GetFaceNumber()
        {
            switch (Type)
            {
                case DiceType.d4:
                    return 4;
                case DiceType.d6:
                    return 6;
                case DiceType.d8:
                    return 8;
                case DiceType.d10:
                    return 10;
                case DiceType.d12:
                    return 12;
                case DiceType.d20:
                    return 20;
                case DiceType.d100:
                    return 100;
                default: 
                    return 0;
            }
        }
    }
}
