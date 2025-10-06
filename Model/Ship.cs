

namespace Model
{
    public class Ship : IDomainObject
    {
        public Ship(string name, FlagColor flagColor) 
        {
            Name = name;
            Hp = 100;
            FlagColor = flagColor;
            IsYourTurn = false;
        }


        private int id;
        private string name;
        private short hp;
        private FlagColor flagColor;
        private bool isYourTurn;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value; 
        }

        public short Hp
        {
            get => hp;
            set => hp = value; 
        }

        public FlagColor FlagColor
        {
            get => flagColor;
            set => flagColor = value;
        }

        public bool IsYourTurn
        {
            get => isYourTurn;
            set => isYourTurn = value;
        }
    }
}
