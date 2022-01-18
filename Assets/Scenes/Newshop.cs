using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Newshop : Product
{
    public override decimal GetRevenue(int level) => 10000000 * level + 10000000;

    public override decimal Rps => 100 * Level + 100;
    public override int action => 9;
}
