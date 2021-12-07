using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WCHam : Product
{
    public override decimal Revenue => 50000 * Level + 75000;

    public override decimal Rps => 100 * Level + 300;
}
