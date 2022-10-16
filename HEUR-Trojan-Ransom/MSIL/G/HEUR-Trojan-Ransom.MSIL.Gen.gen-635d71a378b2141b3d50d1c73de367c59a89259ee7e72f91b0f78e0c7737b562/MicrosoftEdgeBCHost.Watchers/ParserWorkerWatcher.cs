using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParserWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralObject()
	{
	}
}
