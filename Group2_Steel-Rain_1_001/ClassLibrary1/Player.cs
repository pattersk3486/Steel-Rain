using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player
    { //Fields
        private string _name;
        private string _password;
        private string _warrior;
        private string _gunslinger;
        //Constructor
        public Player()
        {
            Name = "";
            Password = "";
            Warrior = "Warrior";
            Gunslinger = "Gunslinger";

        }
        public Player (string name, string password, string warrior, string gunslinger)
        {
            Name = name;
            Password = password;
            Warrior = warrior;
            Gunslinger = gunslinger;
        }
        //Full property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string Warrior
        {
            get
            {
                return _warrior;
            }
            set
            {
                _warrior = value;
            }
        }
        public string Gunslinger
        {
            get
            {
                return _gunslinger;
            }
            set
            {
                _gunslinger = value;
            }
        }
            
            


    }
}
