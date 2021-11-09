using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BHam : Product
{
    public override decimal Revenue => 2000 * Level + 2000;

    public override decimal Rps => 15 * Level + 30;
}
