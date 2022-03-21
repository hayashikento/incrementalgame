using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EHam : Product
{
    public override decimal GetRevenue(int level) => 100000 * level + 100000;

    public override decimal Rps => 125 * Level + 450;
    public override int action => 8;
}
