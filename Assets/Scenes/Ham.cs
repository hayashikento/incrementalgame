using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ham : Product
{
	public override decimal Revenue => 1000 * Level + 2500;

	public override decimal Rps => 30 * Level + 100;
}
