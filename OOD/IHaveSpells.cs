using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public interface ICastSpell
    {
        void CastSpellTo (Student sc, Student sa);
        string Name { get; }
    }
}
