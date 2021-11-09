using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Newshop : Product
{
    public override decimal Revenue => 10000000 * Level + 10000000;

    public override decimal Rps => 100 * Level + 100;
}
