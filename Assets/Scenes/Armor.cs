using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Armor : Product
{
    public override decimal Revenue => 9000 * Level + 9000;

    public override decimal Rps => 30 * Level + 45;
}
