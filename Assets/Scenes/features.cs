using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class features
{
   
    public double revenue;
    public double rps;
    public int hamLevel;
    public int BhamLevel;
    public int ChamLevel;
    public int ShamLevel;
    public int WChamLevel;
    public int EhamLevel;
    public int ITLevel;
    public int AMLevel;
    public int CMLevel;
    public int NSLevel;
    public int SNSLevel;
    public bool ham;
    public bool Bham;
    public bool Sham;
    public bool Cham;
    public bool WCham;
    public bool Eham;
    public bool IT;
    public bool AM;
    public bool CM;
    public bool NS;
    public int action;
    public DateTime datetime;
         // Start is called before the first frame update
}
public class FeaturesSet
{
    public List<features> Features;

    public FeaturesSet()
    {
        Features = new List<features>();
    }
    // Start is called before the first frame update
}

