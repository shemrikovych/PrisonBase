using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonBase.Elements
{
   public interface IBase
    {
        List<Prisoner> Prisoners { get; }
        Prisoner AddPrisoner(Prisoner prisoner);
        void DeletePrisoner(string id);
        void SavePrisoner();
        void LoadBase();
    }
}
