using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralContext()
	{
	}
}
