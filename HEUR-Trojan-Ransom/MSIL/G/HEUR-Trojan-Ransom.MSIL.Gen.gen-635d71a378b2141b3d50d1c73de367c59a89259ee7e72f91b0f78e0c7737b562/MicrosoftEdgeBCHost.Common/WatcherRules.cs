using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WatcherRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherRules()
	{
		WriterPropertyProducer.ResolveStub();
		CountParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountParam()
	{
	}
}
