using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CHam : Product
{
    public override decimal GetRevenue(int level) => 20000 * level + 50000;

    public override decimal Rps => 70 * Level + 200;
    public override int action => 6;
}
