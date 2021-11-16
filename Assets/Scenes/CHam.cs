using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CHam : Product
{
    public override decimal Revenue => 5000 * Level + 5000;

    public override decimal Rps => 50 * Level + 50;
}
