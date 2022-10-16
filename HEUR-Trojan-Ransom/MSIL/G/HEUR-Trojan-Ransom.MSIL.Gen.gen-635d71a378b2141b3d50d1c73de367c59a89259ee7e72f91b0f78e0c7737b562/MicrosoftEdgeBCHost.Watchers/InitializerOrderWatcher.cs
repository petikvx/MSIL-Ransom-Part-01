using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralComparator()
	{
	}
}
