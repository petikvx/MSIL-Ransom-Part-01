using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ErrorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralConfiguration()
	{
	}
}
