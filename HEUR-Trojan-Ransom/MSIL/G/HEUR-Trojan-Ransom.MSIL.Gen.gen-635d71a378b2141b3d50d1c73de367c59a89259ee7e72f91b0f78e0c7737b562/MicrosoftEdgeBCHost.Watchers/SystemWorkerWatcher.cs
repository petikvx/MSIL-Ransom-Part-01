using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SystemWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceInterceptor()
	{
	}
}
