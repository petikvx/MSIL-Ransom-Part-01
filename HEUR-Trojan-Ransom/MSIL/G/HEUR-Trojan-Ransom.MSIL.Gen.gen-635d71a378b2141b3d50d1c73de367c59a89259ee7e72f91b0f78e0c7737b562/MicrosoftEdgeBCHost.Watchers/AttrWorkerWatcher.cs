using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceDatabase()
	{
	}
}
