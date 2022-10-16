using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExceptionWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceInfo()
	{
	}
}
