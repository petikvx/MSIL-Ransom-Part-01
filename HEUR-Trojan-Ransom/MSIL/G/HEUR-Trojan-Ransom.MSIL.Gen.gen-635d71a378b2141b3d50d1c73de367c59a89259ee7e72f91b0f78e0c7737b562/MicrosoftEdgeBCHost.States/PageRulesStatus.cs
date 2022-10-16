using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PageRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceProxy()
	{
	}
}
