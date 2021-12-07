using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BHam : Product
{
    public override decimal Revenue => 5000 * Level + 10000;

    public override decimal Rps => 30 * Level + 150;
}
