namespace Coache.Common;

public class Rubro
{
	public int ID { get; set; }

	public string Name { get; set; }

	public override bool Equals(object obj)
	{
		if (!(obj is Rubro))
		{
			return false;
		}
		return ((Rubro)obj).ID == ID;
	}

	public override int GetHashCode()
	{
		return ID.GetHashCode();
	}
}
