using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SHam : Product
{
    public override decimal Revenue => 3000 * Level + 3000;

    public override decimal Rps => 20 * Level + 40;
}
