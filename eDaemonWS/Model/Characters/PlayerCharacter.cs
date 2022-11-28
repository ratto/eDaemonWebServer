namespace eDaemonWS.Model.Characters
{
    public class PlayerCharacter : Character
    {
        private int _experience;

        public PlayerCharacter(byte id, string name, byte strength, byte agility, byte dexterity, byte constitution, 
            byte intelligence, byte willPower, byte perception, byte charisma) : base(id, name, strength, agility, dexterity, constitution, 
                intelligence, willPower, perception, charisma)
        {
            _experience = 0;
        }
    }
}
