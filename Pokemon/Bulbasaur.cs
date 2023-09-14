using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Bulbasaur : Monster
    {
        public Bulbasaur(string a_sNickname) : base(a_sNickname)
        {

        }

        public Bulbasaur(string a_sNickname, int a_nLevel) : base(a_sNickname, a_nLevel)
        {
        }

        override protected void Init(string a_sNickname, int a_nLevel)
        {
            base.Init(a_sNickname, a_nLevel);
            Console.WriteLine("I'm also a Bulbasaur");
        }
    }
}
