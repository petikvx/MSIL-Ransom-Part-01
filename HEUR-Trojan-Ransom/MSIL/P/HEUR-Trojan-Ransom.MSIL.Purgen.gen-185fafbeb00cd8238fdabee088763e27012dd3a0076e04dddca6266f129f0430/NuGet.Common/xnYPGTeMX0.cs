using System;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public class xnYPGTeMX0
{
	[CompilerGenerated]
	private readonly bool d76Wfrdh6g;

	[CompilerGenerated]
	private static readonly xnYPGTeMX0 CPvG9S6zKg = new xnYPGTeMX0(new H2NcfQ37eg());

	public bool kfJMKmpbLC
	{
		[CompilerGenerated]
		get
		{
			return d76Wfrdh6g;
		}
	}

	public static xnYPGTeMX0 fJSUgG00YX
	{
		[CompilerGenerated]
		get
		{
			return CPvG9S6zKg;
		}
	}

	public xnYPGTeMX0(IEnvironmentVariableReader reader)
	{
		d76Wfrdh6g = bzdic0eFtw(reader);
	}

	private static bool bzdic0eFtw(IEnvironmentVariableReader arq5Dvwn0R)
	{
		string environmentVariable = arq5Dvwn0R.GetEnvironmentVariable("NUGET_SHOW_STACK");
		if (environmentVariable == null)
		{
			return false;
		}
		return string.Equals(environmentVariable.Trim(), "true", StringComparison.OrdinalIgnoreCase);
	}
}
