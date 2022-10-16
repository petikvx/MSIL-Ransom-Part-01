using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceClient()
	{
	}
}
