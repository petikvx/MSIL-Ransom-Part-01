namespace MySql.Data.MySqlClient.Authentication;

public struct SECURITY_INTEGER
{
	public uint LowPart;

	public int HighPart;

	public SECURITY_INTEGER(int dummy)
	{
		LowPart = 0u;
		HighPart = 0;
	}
}
