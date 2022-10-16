using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceServer()
	{
	}
}
