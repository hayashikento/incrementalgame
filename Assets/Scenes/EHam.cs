using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EHam : Product
{
    public override decimal Revenue => 100000 * Level + 100000;

    public override decimal Rps => 125 * Level + 450;
}
