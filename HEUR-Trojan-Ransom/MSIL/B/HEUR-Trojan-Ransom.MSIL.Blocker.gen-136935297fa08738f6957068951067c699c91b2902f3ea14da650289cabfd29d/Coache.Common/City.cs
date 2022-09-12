namespace Coache.Common;

public class City
{
	public int ID { get; set; }

	public string Name { get; set; }

	public override bool Equals(object obj)
	{
		if (!(obj is City))
		{
			return false;
		}
		return ((City)obj).ID == ID;
	}

	public override int GetHashCode()
	{
		return ID.GetHashCode();
	}
}
