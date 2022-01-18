using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ham : Product
{
	public override decimal GetRevenue(int level) => 1000 * level + 2500;

	public override decimal Rps => 30 * Level + 100;

	public override int action => 0;
}
