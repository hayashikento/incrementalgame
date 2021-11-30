using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EHam : Product
{
    public override decimal Revenue => 7000 * Level + 7000;

    public override decimal Rps => 50 * Level + 70;
}
