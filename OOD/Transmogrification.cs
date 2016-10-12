using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class Transmogrification : Spell, ICastSpell
    {
        public Transmogrification(string name, string desc, Difficulty lv) : base(name, desc)
        {
            SpellLevel = lv;
        }

        public void CastSpellTo(Student sc, Student sa)
        {
            Random rnd1 = new Random();
            int rand = rnd1.Next(0, 100);
            int levelGap = (int)sc.TransmogLevel - (int)this.SpellLevel;
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
                TransmoSuccessful(sc, sa);
            }
            else TransmoFailure(sc, sa);
            Console.WriteLine("Level Positive Gap: " + levelGap);
            Console.WriteLine("Success Rate: " + chance);
        }

        public void TransmoSuccessful(Student sc, Student sa)
        {
            int sich = 100 + ((int)sc.TransmogLevel - 1) * 100;
            sa.Size += sich;
            Console.WriteLine("Success !!! His size have been up by " + sich + " !!!");
        }

        public void TransmoFailure(Student sc, Student sa)
        {
            sa.Size -= 100;
            Console.WriteLine("Failure !!! His size have been down by 100 !!!");
        }
    }
    //see 4.1 p11
}
