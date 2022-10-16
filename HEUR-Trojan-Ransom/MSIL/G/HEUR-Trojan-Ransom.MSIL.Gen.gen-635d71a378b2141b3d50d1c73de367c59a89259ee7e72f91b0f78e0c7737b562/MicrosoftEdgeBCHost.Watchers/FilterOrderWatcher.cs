using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralParser()
	{
	}
}
