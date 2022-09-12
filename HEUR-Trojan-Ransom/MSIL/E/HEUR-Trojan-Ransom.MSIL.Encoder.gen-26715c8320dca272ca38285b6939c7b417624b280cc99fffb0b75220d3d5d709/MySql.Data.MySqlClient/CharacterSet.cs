namespace MySql.Data.MySqlClient;

public class CharacterSet
{
	public string name;

	public int byteCount;

	public CharacterSet(string name, int byteCount)
	{
		this.name = name;
		this.byteCount = byteCount;
	}

	public override int GetHashCode()
	{
		return (((name != null) ? name.GetHashCode() : 0) * 397) ^ byteCount;
	}
}
