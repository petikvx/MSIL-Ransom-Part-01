using System.Collections.Generic;

namespace Elfie_city;

public class OrcishCrossbowman : OrcishUnit
{
	public static List<OrcishCrossbowman> OrcishList = new List<OrcishCrossbowman>();

	public new static int Damage = 5;

	public new static int HealthPoints = 5;

	public OrcishCrossbowman()
	{
		OrcishList.Add(this);
	}
}
