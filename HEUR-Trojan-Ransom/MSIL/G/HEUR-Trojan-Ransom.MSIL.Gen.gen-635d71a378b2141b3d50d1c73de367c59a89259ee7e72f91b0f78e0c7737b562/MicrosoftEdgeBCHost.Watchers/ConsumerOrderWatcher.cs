using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConsumerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralComposer()
	{
	}
}
