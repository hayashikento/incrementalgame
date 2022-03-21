using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CM : Product
{
    public override decimal GetRevenue(int level) => 15000 * level + 15000;

    public override decimal Rps => 30 * Level + 30;
    public override int action => 3;
}
