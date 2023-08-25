using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTown.Tests
{
    public class NotFoundException : Exception
    {
        public NotFoundException(): base("Ne peut pas y avoir moins de 2 charactères") { }
    }
}
