using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceList()
	{
	}
}
