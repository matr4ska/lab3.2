

namespace ClassLibrary
{
    public class Ship
    {
        public Ship(int id, string name, FlagColor flagColor) 
        {
            Id = id;
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
