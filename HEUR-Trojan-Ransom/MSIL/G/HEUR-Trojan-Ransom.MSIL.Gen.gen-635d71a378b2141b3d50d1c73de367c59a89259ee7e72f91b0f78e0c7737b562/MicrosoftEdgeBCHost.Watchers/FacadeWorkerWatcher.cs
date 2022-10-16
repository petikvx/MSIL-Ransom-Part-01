using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadeWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceRequest()
	{
	}
}
