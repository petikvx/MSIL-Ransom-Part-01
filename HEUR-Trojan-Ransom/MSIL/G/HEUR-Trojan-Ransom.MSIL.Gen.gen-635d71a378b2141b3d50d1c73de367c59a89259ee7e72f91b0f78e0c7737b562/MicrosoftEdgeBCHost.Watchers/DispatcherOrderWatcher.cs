using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralParameter()
	{
	}
}
