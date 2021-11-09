using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Product
{
    private const int MaxLevel = 10;
    public int Level { get; set; }
    public abstract decimal Revenue { get; }
    public abstract decimal Rps { get; }

    public virtual bool IsMaxLevel()
    {
        return Level >= MaxLevel;
    }
}
