using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class Healing : Spell, ICastSpell
    {
        public Healing(string name, string desc, Difficulty lv) : base(name, desc)
        {
            SpellLevel = lv;
        }

        public Healing() : base()
        {
            
        }

        public void CastSpellTo(Student sc, Student sa)
        {
            Random rnd1 = new Random();
            int rand = rnd1.Next(0, 100);
            int levelGap = (int)sc.HealingLevel - (int)this.SpellLevel;
            int chance = BaseChance;
            if (levelGap > 0)
            {
                chance = BaseChance + 49;
            }
            else if(levelGap < 0)
            {
                chance = BaseChance - 20 * (0- levelGap);
            }
            else chance = BaseChance + 48;

            if (rand < chance)
            {
                HealSuccessful(sc, sa);
            }
            else HealFailure(sc, sa);
            Console.WriteLine("Level Positive Gap: " + levelGap);
            Console.WriteLine("Success Rate: " + chance);
        }

        public void HealSuccessful(Student sc, Student sa)
        {
            int sup = 100 + ((int)sc.HealingLevel - 1) * 100;
            sa.Spirit += sup;
            Console.WriteLine("Success !!! His spirits have been up by " + sup + " !!!");
        }

        public void HealFailure(Student sc, Student sa)
        {
            sc.Spirit -= 100;
            Console.WriteLine("Failure !!! Your spirits have been down by 100 !!!");
        }
    }

    //see 4.1 p11
}
