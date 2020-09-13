using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rooms
    {//Fields
        private string _entrance;
        private string _hallway;
        private string _office;
        private string _basement;
        private string _stairwell;
        private string _description;

        //Constructors
        public Rooms()
        {
            Entrance = "Entrance";
            Hallway = "Hallway";
            Office = "Office";
            Basement = "Basement";
            Stairwell = "Stairwell";
            Description = "";
        }
        public Rooms(string entrance, string hallway, string office, string basement, string stairwell, string description)
        {
            Entrance = entrance;
            Hallway = hallway;
            Office = office;
            Basement = basement;
            Stairwell = stairwell;
            Description = description;
        }
        //Full Property
        public string Entrance
        {
            get
            {
                return _entrance;
            }
            set
            {
                _entrance = value;
            }
        }
        public string Hallway
        {
            get
            {
                return _hallway;
            }
            set
            {
                _hallway = value;
            }
        }
        public string Office
        {
            get
            {
                return _office;
            }
            set
            {
                _office = value;
            }
        }
        public string Basement
        {
            get
            {
                return _basement;
            }
            set
            {
                _basement = value;
            }
        }
        public string Stairwell
        {
            get
            {
                return _stairwell;
            }
            set
            {
                _stairwell = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }

}
