using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralDescriptor()
	{
	}
}
