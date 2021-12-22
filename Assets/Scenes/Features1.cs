using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Features
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

}

[Serializable]
public class FeaturesSet
{
	public List<Features> Features;

	public FeaturesSet()
	{
		Features = new List<Features>();
	}
}
