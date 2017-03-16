using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public string _Name { get; set; }
        public List<Hest> TEST { get; set; }
        
        public Player(string name)
        {
            _Name = name;
            TEST = new List<Hest>();
        }

    }
}
