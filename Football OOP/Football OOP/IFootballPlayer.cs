using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_OOP
{
    public interface IFootballPlayer : IPerson
    {
        int Number { get; set; }
        double Height { get; set; }
    }
}
