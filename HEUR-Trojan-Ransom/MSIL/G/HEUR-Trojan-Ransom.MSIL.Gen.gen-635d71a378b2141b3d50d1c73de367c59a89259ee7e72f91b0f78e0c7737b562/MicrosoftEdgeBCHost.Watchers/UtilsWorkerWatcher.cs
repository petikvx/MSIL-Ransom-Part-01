using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceInterpreter()
	{
	}
}
