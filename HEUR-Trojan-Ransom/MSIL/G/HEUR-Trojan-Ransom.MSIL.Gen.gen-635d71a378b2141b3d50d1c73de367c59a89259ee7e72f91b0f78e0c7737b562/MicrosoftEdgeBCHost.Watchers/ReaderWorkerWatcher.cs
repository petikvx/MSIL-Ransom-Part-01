using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceDatabase()
	{
	}
}
