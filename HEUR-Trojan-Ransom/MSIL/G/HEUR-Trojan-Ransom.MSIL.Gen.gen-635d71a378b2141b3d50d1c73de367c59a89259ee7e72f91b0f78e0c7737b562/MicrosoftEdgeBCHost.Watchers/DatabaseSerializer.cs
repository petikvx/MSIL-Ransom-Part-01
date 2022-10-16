using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralState()
	{
	}
}
