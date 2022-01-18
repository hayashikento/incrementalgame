using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SHam : Product
{
    public override decimal GetRevenue(int level) => 10000 * level + 30000;

    public override decimal Rps => 50 * Level + 200;
    public override int action => 2;
}
