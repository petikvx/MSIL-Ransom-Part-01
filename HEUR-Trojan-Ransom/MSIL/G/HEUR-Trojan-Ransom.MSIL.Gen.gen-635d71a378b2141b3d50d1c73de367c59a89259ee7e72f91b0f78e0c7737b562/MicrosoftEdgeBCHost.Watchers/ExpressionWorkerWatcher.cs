using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExpressionWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceContainer()
	{
	}
}
