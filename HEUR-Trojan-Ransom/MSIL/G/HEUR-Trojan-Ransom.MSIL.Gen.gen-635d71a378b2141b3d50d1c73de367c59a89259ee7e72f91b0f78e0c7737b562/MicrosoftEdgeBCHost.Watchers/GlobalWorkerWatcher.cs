using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceInterpreter()
	{
	}
}
