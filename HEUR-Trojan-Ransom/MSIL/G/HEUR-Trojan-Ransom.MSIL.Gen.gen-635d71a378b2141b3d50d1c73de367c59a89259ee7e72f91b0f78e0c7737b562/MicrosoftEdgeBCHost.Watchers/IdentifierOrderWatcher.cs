using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralTag()
	{
	}
}
