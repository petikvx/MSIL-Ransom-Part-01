using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralRef()
	{
	}
}
