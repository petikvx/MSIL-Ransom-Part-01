using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LoginFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginFilter()
	{
	}
}
