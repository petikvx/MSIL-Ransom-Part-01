using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatThread()
	{
	}
}
