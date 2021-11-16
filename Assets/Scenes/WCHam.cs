using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WCHam : Product
{
    public override decimal Revenue => 6000 * Level + 6000;

    public override decimal Rps => 60 * Level + 60;
}
