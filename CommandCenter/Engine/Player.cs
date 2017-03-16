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
        public int _ID { get; set; }
        
        public Player(string name, int id)
        {
            _Name = name;
            _ID = id;
        }

    }
}
