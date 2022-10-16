using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MethodBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateIndexer()
	{
	}
}
