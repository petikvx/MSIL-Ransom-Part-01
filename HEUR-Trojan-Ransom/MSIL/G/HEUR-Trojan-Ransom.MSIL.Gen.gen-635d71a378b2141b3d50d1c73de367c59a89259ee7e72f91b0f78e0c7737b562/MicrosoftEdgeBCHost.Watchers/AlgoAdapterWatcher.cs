using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralRegistry()
	{
	}
}
