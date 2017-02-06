using Maya.Common.Board;
using Maya.Common.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Concrete
{
    public class BroadFactory : IBroadFactory
    {
        public IBoard CreateBoard()
        {
            return new GameBoard(); 
        }

    }
}
