using System;
using Microsoft.VisualBasic.CompilerServices;
using NanoCore.ClientPlugin;
using NanoCore.ClientPluginHost;

[StandardModule]
internal sealed class Class6
{
	public static Type[] type_0 = new Type[3]
	{
		typeof(IClientNetwork),
		typeof(IClientData),
		typeof(IClientApp)
	};

	public static Type[] type_1 = new Type[5]
	{
		typeof(IClientDataHost),
		typeof(IClientNetworkHost),
		typeof(IClientUIHost),
		typeof(IClientLoggingHost),
		typeof(IClientAppHost)
	};
}
