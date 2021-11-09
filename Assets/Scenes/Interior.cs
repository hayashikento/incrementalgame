using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Interior : Product
{
    public override decimal Revenue => 10000 * Level + 10000;

    public override decimal Rps => 40 * Level + 50;
}
