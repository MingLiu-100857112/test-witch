using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class SpellBook
    {
        private List<Spell> _spellls;

        public SpellBook()
        {

        }

        public string SpellList
        {
            get
            {
                string ss = "";
                foreach (Spell s in _spellls)
                    ss = s + "   " + s.Description + "\n";
                return ss;
            }
        }


        //This is very important!!! to 
        //because otherwise you don't save the new List<Spell>() you created and every time you use the get you recreate it (the get returns a new List<Spell>() but doesn't modify _spells, so every get checks _spells, see it's null and return a new List<Note>())
        public List<Spell> Spells
        {
            get
            {
                if (_spellls == null)
                {
                    _spellls = new List<Spell>();
                    _spellls.Add(new Healing());
                }
                return _spellls;
            }
        }

        public string SpellsLearned
        {
            get
            {
                string str = "";
                foreach (Spell s in Spells)
                    str = str + "   " + "\"" + s.Name + "\"" + " Level: " + s.SpellLevel.ToString() + " \"" + s.Description + "\" " + "\n";
                return str;
            }
        }

        public void Put(Spell itm)
        {
            Spells.Add(itm);
        }

        public Spell Fetch(string id)
        {
            foreach (Spell i in _spellls)
            {
                if (i.AreYou(id))
                {
                    return i;
                }
            }
            return null;
        }

        //if no _spellls.Add(new Healing()); then break occurs here
        public Spell SpellRandomAssigned(int i)
        {
            Spell sp = new Spell();
            if (_spellls.ElementAt(i) != null)
            {
                sp = _spellls.ElementAt(i);
                _spellls.Remove(_spellls.ElementAt(i));
                return sp;
            }
            return null;
        }
    }
}
