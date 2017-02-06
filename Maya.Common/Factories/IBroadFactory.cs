using Maya.Common.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Common.Factories
{
    public interface IBroadFactory
    {
        IBoard CreateBoard();
    }
}
