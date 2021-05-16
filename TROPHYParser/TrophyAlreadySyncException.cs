using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TROPHYParser
{
    class TrophyAlreadySyncException : Exception
    {
        public TrophyAlreadySyncException(string message) : base(message) { }
        public TrophyAlreadySyncException() : base("Trophy already synchronized. Can't be modified.") { }
    }
}
