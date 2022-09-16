namespace Traffic_Simulation;

internal class CarInfo
{
	public int id { get; private set; }

	public WhereIsNow iAmHere { get; set; }

	public int countMove { get; set; }

	public CarInfo(int id)
	{
		this.id = id;
		iAmHere = WhereIsNow.Beginning;
		countMove = -1;
	}
}
