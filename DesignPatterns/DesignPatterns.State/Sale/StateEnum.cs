using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Sale
{
    internal enum StateEnum
    {
        ON_APPROVAL = 1,
        APPROVED = 2,
        REPROVED = 3,
        FINISHED = 4,
    }
}
