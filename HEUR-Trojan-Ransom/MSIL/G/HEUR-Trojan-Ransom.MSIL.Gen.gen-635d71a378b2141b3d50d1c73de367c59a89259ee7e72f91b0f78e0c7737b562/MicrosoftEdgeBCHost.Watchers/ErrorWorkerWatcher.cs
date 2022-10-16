using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ErrorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceInfo()
	{
	}
}
