using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("one", "I am one", 1000, 1000, 1000, 1000, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
            Student s2 = new Student("two", "I am two", 1001, 1001, 1001, 1001, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
            Student s3 = new Student("three", "I am three", 1002, 1002, 1002, 1002, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
            Student s4 = new Student("four", "I am four", 1003, 1003, 1003, 1003, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
            Student s5 = new Student("five", "I am five", 1004, 1004, 1004, 1004, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
            Student s6 = new Student("six", "I am six", 1005, 1005, 1005, 1005, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
            Student s7 = new Student("seven", "I am seven", 1006, 1006, 1006, 1006, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
            Student s8 = new Student("eight", "I am eight", 1007, 1007, 1007, 1007, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);
            Student s9 = new Student("nine", "I am nine", 1008, 1008, 1008, 1008, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);
            Student s10 = new Student("ten", "I am ten", 1009, 1009, 1009, 1009, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);

            Healing h1 = new Healing("Buda's sigh", "Spirits + 100", Spell.Difficulty.Easy);
            Healing h2 = new Healing("Buda's laugh", "Spirits + 200", Spell.Difficulty.Medium);
            Healing h3 = new Healing("Buda's cry", "Spirits + 300", Spell.Difficulty.Hard);
            Healing h4 = new Healing("Buda's gasp", "Spirits + 100", Spell.Difficulty.Hard);
            Healing h5 = new Healing("Buda's talk", "Spirits + 200", Spell.Difficulty.Easy);
            Healing h6 = new Healing("Buda's cloud", "Spirits + 300", Spell.Difficulty.Medium);
            Transmogrification tr1 = new Transmogrification("Titan's finger", "Size + 100", Spell.Difficulty.Easy);
            Transmogrification tr2 = new Transmogrification("Titan's hand", "Size + 200", Spell.Difficulty.Medium);
            Transmogrification tr3 = new Transmogrification("Titan's leg", "Size + 300", Spell.Difficulty.Hard);
            Transmogrification tr4 = new Transmogrification("Titan's hair", "Size + 100", Spell.Difficulty.Hard);
            Transmogrification tr5 = new Transmogrification("Titan's head", "Size + 200", Spell.Difficulty.Easy);
            Transmogrification tr6 = new Transmogrification("Titan's back", "Size + 300", Spell.Difficulty.Easy);
            Transmogrification tr7 = new Transmogrification("Titan's slash", "Size + 300", Spell.Difficulty.Medium);
            Teleportation tl1 = new Teleportation("Sonic", "X + 100, Y + 100", Spell.Difficulty.Easy);
            Teleportation tl2 = new Teleportation("Supersonic", "X + 200, Y + 200", Spell.Difficulty.Medium);
            Teleportation tl3 = new Teleportation("Light", "X + 300, Y + 300", Spell.Difficulty.Hard);
            Teleportation tl4 = new Teleportation("Splash", "X + 100, Y + 100", Spell.Difficulty.Hard);
            Teleportation tl5 = new Teleportation("Thunder", "X + 200, Y + 200", Spell.Difficulty.Easy);
            Teleportation tl6 = new Teleportation("Cosmo", "X + 300, Y + 300", Spell.Difficulty.Medium);
            Teleportation tl7 = new Teleportation("Gaia", "X + 300, Y + 300", Spell.Difficulty.Easy);

            SpellBook sb = new SpellBook();
            sb.Put(h1);
            sb.Put(h2);
            sb.Put(h3);
            sb.Put(h4);
            sb.Put(h5);
            sb.Put(h6);
            sb.Put(tr1);
            sb.Put(tr2);
            sb.Put(tr3);
            sb.Put(tr4);
            sb.Put(tr5);
            sb.Put(tr6);
            sb.Put(tr7);
            sb.Put(tl1);
            sb.Put(tl2);
            sb.Put(tl3);
            sb.Put(tl4);
            sb.Put(tl5);
            sb.Put(tl6);
            sb.Put(tl7);

            StudentList sl = new StudentList();
            sl.Put(s1);
            sl.Put(s2);
            sl.Put(s3);
            sl.Put(s4);
            sl.Put(s5);
            sl.Put(s6);
            sl.Put(s7);
            sl.Put(s8);
            sl.Put(s9);
            sl.Put(s10);

            int spLast = 21;
            int stLast = 11;
            Random spRnd = new Random();
            Random stRnd = new Random();
            while (sb != null && spLast >=1)
            {
                int spRsn = spRnd.Next(1, spLast);
                int stRsn = stRnd.Next(1, stLast);
                sl.StudentRandomAssigned(stRsn-1).Spells.Put(sb.SpellRandomAssigned(spRsn-1));
                spLast -= 1;
            }

            foreach (Student s in sl.Students.ToArray())
            {
                Console.WriteLine(s.Status());
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Enter Spell Caster's Name:   ");
                string spc = Console.ReadLine();
                Student scp = sl.Fetch(spc);
                Console.WriteLine(scp.Status());
                Console.WriteLine("Enter the spell you want him to cast:    ");
                string spn = Console.ReadLine();
                ICastSpell spellced = scp.Locate(spn);
                Console.WriteLine("Enter Spell Accepter's Name:   ");
                string spa = Console.ReadLine();
                Student sap = sl.Fetch(spa);
                Console.WriteLine(sap.Status());

                string rtc = "y";
                while (rtc == "y")
                {
                    Console.WriteLine("Ready to Cast Spell?   Enter y/n");
                    rtc = Console.ReadLine();
                    Console.WriteLine();
                    if (rtc == "y")
                    {
                        spellced.CastSpellTo(scp, sap);
                    }
                    Console.WriteLine(sap.Status());
                }

                foreach (Student s in sl.Students.ToArray())
                {
                    Console.WriteLine(s.Status());
                }
            }
        }
    }
}
