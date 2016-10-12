using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class Student : GameObject
    {
        private SpellBook _spells;

        public SpellBook Spells
        {
            get
            {
                if (_spells == null)
                {
                    _spells = new SpellBook();
                }
                return _spells;
            }

            set
            {
                _spells = value;
            }
        }

        private int _spirit, _size;
        public int Spirit
        {
            get
            {
                return _spirit;
            }

            set
            {
                _spirit = value;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }

        private float _x, _y;
        public float X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public Levels HealingLevel
        {
            get
            {
                return _healingLevel;
            }

            set
            {
                _healingLevel = value;
            }
        }

        public Levels TelepLevel
        {
            get
            {
                return _telepLevel;
            }

            set
            {
                _telepLevel = value;
            }
        }

        public Levels TransmogLevel
        {
            get
            {
                return _transmogLevel;
            }

            set
            {
                _transmogLevel = value;
            }
        }

        public enum Levels
        {
            Novice = 1, Adept = 2, Master = 3
        }

        private Levels _healingLevel;
        private Levels _telepLevel;
        private Levels _transmogLevel;

        public Student(string name, string desc, int spirit, int size, float x, float y, Levels hl, Levels tl, Levels tr) : base(name, desc)
        {
            Spirit = spirit;
            Size = size;
            X = x;
            Y = y;
            _healingLevel = hl;
            _telepLevel = tl;
            _transmogLevel = tr;

        }

        public Student() : base("null", "null")
        {
            Spirit = 0;
            Size = 0;
            X = 0;
            Y = 0;
            HealingLevel = Levels.Novice;
            TelepLevel = Levels.Novice;
            TransmogLevel = Levels.Novice;
        }

        public string Status()
        {
            string s = "Name: " + Name + "\n" + "   Spirits: " + Spirit + " Size: " + Size + " Location " + "X: " + X + " Y: " + Y + "\n" + "       <Healing> Level: " + HealingLevel.ToString() + "\n" + "       <Telep> Level: " + TelepLevel.ToString() + "\n" + "       <Transmog> Level: " + TransmogLevel.ToString() + "\n";
            s += "+++ Spell learned +++ " + "\n" + Spells.SpellsLearned + "\n";
            return s;
        }

        public ICastSpell Locate(string id)
        {
            return this.Spells.Fetch(id) as ICastSpell;
        }
    }
}


/*

public sealed class TestClass
{
    public enum Levels { A, B, C, D, E, F, G, H, ASE, SE, SSE, TL, AM };                  

    private Levels _levels; 
    public Levels Levels
    {
        get { return _levels; }         
    }

    private static TestClass instance = new TestClass();
    public static TestClass Instance
    {
     get { return instance; }
    }   

    public TestClass(){}
}
    }
}
*/