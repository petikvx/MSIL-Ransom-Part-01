using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralThread()
	{
	}
}
