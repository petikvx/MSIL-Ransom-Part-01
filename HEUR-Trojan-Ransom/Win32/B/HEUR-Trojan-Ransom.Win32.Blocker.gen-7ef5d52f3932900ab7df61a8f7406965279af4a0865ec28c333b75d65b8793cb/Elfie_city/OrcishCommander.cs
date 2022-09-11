using System.Collections.Generic;

namespace Elfie_city;

public class OrcishCommander : OrcishUnit
{
	public static List<OrcishCommander> OrcishList = new List<OrcishCommander>();

	public new static int Damage = 12;

	public new static int HealthPoints = 80;

	public OrcishCommander()
	{
		OrcishList.Add(this);
	}
}
