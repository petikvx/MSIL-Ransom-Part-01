using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralAlgo()
	{
	}
}
