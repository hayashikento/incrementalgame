using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SNS : Product
{
    public override decimal GetRevenue(int level) => 0;

    public override decimal Rps => 1;
    public override int action => 10;
}
