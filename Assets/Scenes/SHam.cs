using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SHam : Product
{
    public override decimal Revenue => 10000 * Level + 30000;

    public override decimal Rps => 50 * Level + 200;
}
