using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public abstract class GameObject
    {
        private string _description, _name;
        public GameObject(string name, string desc)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public bool AreYou(string id)
        {
            return _name.Equals(id);
        }
    }
}
