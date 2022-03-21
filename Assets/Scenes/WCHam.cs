using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WCHam : Product
{
    public override decimal GetRevenue(int level) => 50000 * level + 75000;

    public override decimal Rps => 100 * Level + 300;
    public override int action => 7;
}
