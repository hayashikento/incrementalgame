using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CHam : Product
{
    public override decimal Revenue => 20000 * Level + 50000;

    public override decimal Rps => 70 * Level + 200;
}
