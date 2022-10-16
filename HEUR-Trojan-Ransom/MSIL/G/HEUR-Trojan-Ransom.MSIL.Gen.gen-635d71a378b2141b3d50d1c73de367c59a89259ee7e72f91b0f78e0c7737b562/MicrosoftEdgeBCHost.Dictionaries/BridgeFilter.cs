using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeFilter()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutPage()
	{
	}
}
