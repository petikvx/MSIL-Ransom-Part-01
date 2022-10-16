using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceDatabase()
	{
	}
}
