using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompts
{
    public static class StandardMessages
    {
        //public int HP = 50;
            



        public static int Attack()
        {
            var rand = new Random();
            int dmg = rand.Next(1, 21);
            //int hpLeft = hp - dmg;
            Console.WriteLine("You dealt: {0} damage!!\nPress enter to continue.", dmg);
            //Console.WriteLine("The enemy has: {0} HP left", hpLeft);
            Console.ReadLine();
            return dmg;
        }
        
    }
}
