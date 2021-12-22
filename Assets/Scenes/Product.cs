using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Product
{
    private const int MaxLevel = 10;
    public int Level { get; set; }
    public decimal Revenue => GetRevenue(Level);
    public decimal NextRevenue => GetRevenue(Level + 1);
    public abstract decimal Rps { get; }

    public virtual bool IsMaxLevel()
    {
        return Level >= MaxLevel;
    }

    public abstract decimal GetRevenue(int level);
}
