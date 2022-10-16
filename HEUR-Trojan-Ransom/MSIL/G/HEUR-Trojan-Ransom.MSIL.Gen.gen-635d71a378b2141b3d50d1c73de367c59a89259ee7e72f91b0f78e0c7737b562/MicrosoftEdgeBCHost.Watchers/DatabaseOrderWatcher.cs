using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralReader()
	{
	}
}
