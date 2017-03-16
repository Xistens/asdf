using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Player : Unit
    {

        private Experience _EXP { get; set; }
        private uint _experiencePoints;
        
        public uint ExperiencePoints
        {
            get { return _experiencePoints; }
            protected set
            {
                uint XPRequired = _EXP.XPRequired(UnitLevel);
                uint total = _experiencePoints + value;
                // Level up?
                if(total >= XPRequired)
                {
                    _experiencePoints = total - XPRequired;
                    UnitLevel += 1;
                }
                else
                {
                    _experiencePoints += value;
                }
            }
        }

        private Player(uint currentHealth, uint maximumHealth) : base(currentHealth, maximumHealth)
        {
            _EXP = new Experience();
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(100, 100);
            return player;
        }

        // Adds experience points to the player. Test function
        public void SetExperience(uint experience)
        {
            ExperiencePoints = experience;
        }

    }
}
