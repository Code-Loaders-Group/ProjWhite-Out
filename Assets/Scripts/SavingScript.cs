using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingScript
{
    [System.Serializable]
    public class SavingScript 
    {
        public int level;
        public int health;
       /* public SavingScript(Player player)
        {
            level = player.level;
            health = player.health;

        }*/
       //we have to have the script for the player to be able to save this thing, bcs rn it says that there is no 'player' script in it and thats an error
    }


}
