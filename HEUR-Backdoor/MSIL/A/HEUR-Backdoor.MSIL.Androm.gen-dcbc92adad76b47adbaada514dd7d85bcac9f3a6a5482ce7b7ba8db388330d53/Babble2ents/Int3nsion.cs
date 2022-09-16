using System;
using System.Runtime.CompilerServices;
using Balneolo2y;
using ns3;

namespace Babble2ents;

public class Int3nsion
{
	[CompilerGenerated]
	private readonly bool Tor7;

	[CompilerGenerated]
	private static readonly Int3nsion Areni2es = new Int3nsion(new Muse7ul());

	public bool S7uffbox
	{
		[CompilerGenerated]
		get
		{
			return Tor7;
		}
	}

	public static Int3nsion Anth0opology
	{
		[CompilerGenerated]
		get
		{
			return Areni2es;
		}
	}

	public Int3nsion(IEnvironmentVariableReader reader)
	{
		Tor7 = Da66er(reader);
	}

	private static bool Da66er(IEnvironmentVariableReader ienvironmentVariableReader_0)
	{
		string environmentVariable = ienvironmentVariableReader_0.GetEnvironmentVariable("NUGET_SHOW_STACK");
		if (environmentVariable == null)
		{
			return false;
		}
		return string.Equals(environmentVariable.Trim(), "true", StringComparison.OrdinalIgnoreCase);
	}
}
