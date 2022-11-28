using eDaemonWS.Model.General.Enum;

namespace eDaemonWS.Model.Characters
{
    public abstract class Character
    {
        public byte Id { get; set; }
        public string Name { get; }
        public byte Strength { get; set; }
        public byte Agility { get; set; }
        public byte Dexterity { get; set; }
        public byte Constitution { get; set; }
        public byte Intelligence { get; set; }
        public byte WillPower { get; set; }
        public byte Perception { get; set; }
        public byte Charisma { get; set; }
        public byte HitPointsCurrent { get; }

        private byte _hitPointsTotal;

        protected Character(byte id, string name, byte strength, byte agility, byte dexterity, byte constitution, byte intelligence, byte willPower, byte perception, byte charisma)
        {
            Id = id;
            Name = name;
            Strength = strength;
            Agility = agility;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            WillPower = willPower;
            Perception = perception;
            Charisma = charisma;

            _hitPointsTotal = (byte)Math.Ceiling((decimal)(strength + constitution) / 2);
            HitPointsCurrent = _hitPointsTotal;
        }

        public int GetAttributeMod(AttributeType type)
        {
            switch (type)
            {
                case (AttributeType.Strength):
                    return this.Strength * 4;
                case (AttributeType.Agility):
                    return this.Agility * 4;
                case (AttributeType.Dexterity):
                    return this.Dexterity * 4;
                case (AttributeType.Constitution):
                    return this.Constitution * 4;
                case (AttributeType.Intelligence):
                    return this.Intelligence * 4;
                case (AttributeType.WillPower):
                    return this.WillPower * 4;
                case (AttributeType.Perception):
                    return this.Perception * 4;
                case (AttributeType.Charisma):
                    return this.Charisma * 4;
                default:
                    return 0;
            }
        }
    }
}
