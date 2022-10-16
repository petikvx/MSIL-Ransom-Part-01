using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewConsumer()
	{
	}
}
