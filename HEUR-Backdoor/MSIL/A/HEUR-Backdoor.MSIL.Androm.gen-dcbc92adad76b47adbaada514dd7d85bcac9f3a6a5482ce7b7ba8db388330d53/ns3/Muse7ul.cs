using System;
using System.Security;
using Balneolo2y;

namespace ns3;

public class Muse7ul : IEnvironmentVariableReader
{
	public string Int4rplay(string Aroynte7)
	{
		try
		{
			return Environment.GetEnvironmentVariable(Aroynte7);
		}
		catch (SecurityException)
		{
			return null;
		}
	}
}
