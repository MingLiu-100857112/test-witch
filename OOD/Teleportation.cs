using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class Teleportation : Spell, ICastSpell
    {
        public Teleportation(string name, string desc, Difficulty lv) : base(name, desc)
        {
            SpellLevel = lv;
        }

        public void CastSpellTo(Student sc, Student sa)
        {
            Random rnd1 = new Random();
            int rand = rnd1.Next(0, 100);
            int levelGap = (int)sc.TelepLevel - (int)this.SpellLevel;
            int chance = BaseChance;
            if (levelGap > 0)
            {
                chance = BaseChance + 49;
            }
            else if (levelGap < 0)
            {
                chance = BaseChance - 20 * (0 - levelGap);
            }
            else chance = BaseChance + 48;

            if (rand < chance)
            {
                TeleSuccessful(sc, sa);
            }
            else TeleFailure(sc, sa);
            Console.WriteLine("Level Positive Gap: " + levelGap);
            Console.WriteLine("Success Rate: " + chance);
        }

        public void TeleSuccessful(Student sc, Student sa)
        {
            int dch = 100 + ((int)sc.TelepLevel - 1) * 100;
            sa.X += dch;
            sa.Y += dch;
            Console.WriteLine("Success !!! His location X, Y have been changed by " + dch + "!!!");
        }

        public void TeleFailure(Student sc, Student sa)
        {
            sc.Spirit -= 100;
            Console.WriteLine("Bang!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Failure !!! Your spirits have been down by 100 !!!");
        }
    }
    //see 4.1 p11
}
