using System;
using System.Security;

namespace NuGet.Common;

public class H2NcfQ37eg : IEnvironmentVariableReader
{
	public string _35QvCnhRKP(string C8b2ajaf5h)
	{
		try
		{
			return Environment.GetEnvironmentVariable(C8b2ajaf5h);
		}
		catch (SecurityException)
		{
			return null;
		}
	}
}
