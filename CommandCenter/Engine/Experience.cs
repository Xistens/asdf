using System;

namespace src
{
    public class Experience
    {
        // What level the mob must be to be "grey" for player
        protected uint GetGrayLevel(uint pl_level)
        {
            if (pl_level <= 5)
                return 0;
            else if (pl_level <= 39)
                return pl_level - 5 - pl_level / 10;
            // Over 39
            else
                return pl_level - 1 - pl_level / 5;
        }

        // For a given character level, the amount of XP given by lower-level mobs
        // is a linear function of the Mob Level.The amount of experience reaches zero
        // when the difference between the Char Level and Mob Level reaches a certain point.
        // This is called the Zero Difference value
        protected uint GetZeroDifference(uint pl_level)
        {
            if (pl_level < 8) return 5;
            if (pl_level < 10) return 6;
            if (pl_level < 12) return 7;
            if (pl_level < 16) return 8;
            if (pl_level < 20) return 9;
            if (pl_level < 30) return 11;
            if (pl_level < 40) return 12;
            if (pl_level < 45) return 13;
            if (pl_level < 50) return 14;
            if (pl_level < 55) return 15;
            if (pl_level < 60) return 16;
            return 17;
        }

        // Calculate factor to use for calculating player xp
        protected float BaseGainLevelFactor(uint pl_level, uint victim_level)
        {
            // Enemy is higher level
            if (victim_level >= pl_level)
            {
                uint nLevelDiff = victim_level - pl_level;
                if (nLevelDiff > 4)
                    nLevelDiff = 4;
                return 1.0f + 0.05f * nLevelDiff;
            }
            else
            {
                // Victim > "grey" level for player
                uint gray_level = GetGrayLevel(pl_level);
                if (victim_level > gray_level)
                {
                    uint ZD = GetZeroDifference(pl_level);
                    return (ZD + victim_level - pl_level) / (float)ZD;
                }
            }
            return 0;
        }

        
        public uint BaseGain(uint pl_level, uint victim_level)
        {
            const uint nBaseExp = 45;
            
            float xp = (pl_level * 5 + nBaseExp) * BaseGainLevelFactor(pl_level, victim_level);
            return (uint)xp;
        }

        
        // Experience points needed for next level
        public uint XPRequired(uint pl_level)
        {
            return ((8 * pl_level) * BaseGain(pl_level, pl_level));
        }
    }
}
