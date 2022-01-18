using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BHam : Product
{
    public override decimal GetRevenue(int level) => 5000 * level + 10000;

    public override decimal Rps => 30 * Level + 150;
    public override int action => 1;
}