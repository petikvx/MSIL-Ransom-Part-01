using System;
using System.Runtime.Remoting.Messaging;

namespace MLeIeI8C0A;

public static class ecFfHmODrv
{
	private static readonly string _3nG03ie66v = "NuGet.Common.ecFfHmODrv";

	private static readonly string ubZe66KrXd;

	public static string eXt9OAhMjV => (CallContext.LogicalGetData(_3nG03ie66v) as string) ?? ubZe66KrXd;

	public static void TbKkqzfP8V()
	{
		string text = Guid.NewGuid().ToString();
		CallContext.LogicalSetData(_3nG03ie66v, (object)text);
	}

	public static void EMOo5TYCdE()
	{
		CallContext.FreeNamedDataSlot(_3nG03ie66v);
	}

	static ecFfHmODrv()
	{
		Guid empty = Guid.Empty;
		ubZe66KrXd = empty.ToString();
	}
}
