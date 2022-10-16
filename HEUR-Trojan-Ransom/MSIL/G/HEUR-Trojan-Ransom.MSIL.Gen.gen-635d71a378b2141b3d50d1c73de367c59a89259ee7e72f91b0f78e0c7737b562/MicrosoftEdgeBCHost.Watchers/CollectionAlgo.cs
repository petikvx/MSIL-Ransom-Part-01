using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CollectionAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralStatus()
	{
	}
}
