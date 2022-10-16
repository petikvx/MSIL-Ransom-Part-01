using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerRules()
	{
		WriterPropertyProducer.ResolveStub();
		StartOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartOrder()
	{
	}
}
