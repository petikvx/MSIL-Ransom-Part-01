namespace MySql.Data.MySqlClient;

internal class CharacterSet
{
	public string name;

	public int byteCount;

	public CharacterSet(string name, int byteCount)
	{
		this.name = name;
		this.byteCount = byteCount;
	}
}
