//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mob
    {
        //Fields
        private string _crazedbandit;
        private string _marauder;
        private string _shufflingcorpse;
        private string _legendarythief;
        private string _fatman;


        //Constructor
        public Mob()
        {
            CrazedBandit = "Crazed Bandit";
            HP = 15;
            Marauder = "Marauder";
            HP = 15;
            ShufflingCorpse = "Shuffling Corpse";
            HP = 20;
            LegendaryThief = "Legendary Thief";
            HP = 25;
            Fatman = "Fatman";
            HP = 50;
        }
        public Mob(string crazedbandit, string marauder, string shufflingcorpse, string legendarythief, string fatman, int health)
        {
            CrazedBandit = crazedbandit;
            HP = health;
            Marauder = marauder;
            HP = health;
            ShufflingCorpse = shufflingcorpse;
            HP = health;
            LegendaryThief = legendarythief;
            HP = health;
            Fatman = fatman;
            HP = health;
        }
        //Full Property
        public string CrazedBandit
        {
            get
            {
                return _crazedbandit;
            }
            set
            {
                _crazedbandit = value;
            }
        }
        public string Marauder
        {
            get
            {
                return _marauder;
            }
            set
            {
                _marauder = value;
            }
        }
        public string ShufflingCorpse
        {
            get
            {
                return _shufflingcorpse;
            }
            set
            {
                _shufflingcorpse = value;
            }
        }
        public string LegendaryThief
        {
            get
            {
                return _legendarythief;
            }
            set
            {
                _legendarythief = value;
            }
        }
        public string Fatman
        {
            get
            {
                return _fatman;
            }
            set
            {
                _fatman = value;
            }
        }


        //Auto Property
        public int HP { get; set; }

        //Methods
        //public int DoMath()
        //{
        //    return 4 + 5;
        //}
        //public int DoMath(int value1, int value2)
        //{
        //    return value1 + value2;
        //}
    }

}

