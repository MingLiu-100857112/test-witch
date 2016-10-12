using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    //need abstract?
    public class Spell : GameObject
    {
        private int _baseChance;
        public enum Difficulty
        {
            Easy = 1, Medium = 2, Hard =3 
        }
        private Difficulty _spellLevel;
        public Difficulty SpellLevel
        {
            get
            {
                return _spellLevel;
            }

            set
            {
                _spellLevel = value;
            }
        }

        public int BaseChance
        {
            get
            {
                return 50;
            }

            set
            {
                _baseChance = value;
            }
        }

        public Spell(string name, string desc) : base(name, desc)
        {
            
        }

        public Spell() : base("Basic", "Spirits + 100")
        {
            SpellLevel = Difficulty.Easy;
        }

    }
  
}
