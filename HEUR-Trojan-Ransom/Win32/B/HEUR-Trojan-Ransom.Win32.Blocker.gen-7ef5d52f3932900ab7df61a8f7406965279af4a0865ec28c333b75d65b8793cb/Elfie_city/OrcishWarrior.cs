using System.Collections.Generic;

namespace Elfie_city;

public class OrcishWarrior : OrcishUnit
{
	public static List<OrcishWarrior> OrcishList = new List<OrcishWarrior>();

	public new static int Damage = 3;

	public new static int HealthPoints = 15;

	public OrcishWarrior()
	{
		OrcishList.Add(this);
	}
}
