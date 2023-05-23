using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_OOP
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Midfielder : FootballPlayer
    {
        public Midfielder(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Coach : Person { 
        public Coach(string name, int age) : base(name, age)
        {

        }
    }

    public class Referee : Person {
        public Referee(string name, int age) : base(name, age)
        {

        }
    }
}
