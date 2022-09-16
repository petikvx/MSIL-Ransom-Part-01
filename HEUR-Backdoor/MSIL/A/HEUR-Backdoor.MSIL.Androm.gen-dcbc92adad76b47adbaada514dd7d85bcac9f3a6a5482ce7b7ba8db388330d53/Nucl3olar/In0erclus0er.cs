using System;
using System.Runtime.Remoting.Messaging;

namespace Nucl3olar;

public static class In0erclus0er
{
	private static readonly string Bux4mly = "NuGet.Common.In0erclus0er";

	private static readonly string Pe5a5ces;

	public static string Arm6ands => (CallContext.LogicalGetData(Bux4mly) as string) ?? Pe5a5ces;

	public static void Insta1ration()
	{
		string text = Guid.NewGuid().ToString();
		CallContext.LogicalSetData(Bux4mly, (object)text);
	}

	public static void Un6deolog6cal()
	{
		CallContext.FreeNamedDataSlot(Bux4mly);
	}

	static In0erclus0er()
	{
		Guid empty = Guid.Empty;
		Pe5a5ces = empty.ToString();
	}
}
