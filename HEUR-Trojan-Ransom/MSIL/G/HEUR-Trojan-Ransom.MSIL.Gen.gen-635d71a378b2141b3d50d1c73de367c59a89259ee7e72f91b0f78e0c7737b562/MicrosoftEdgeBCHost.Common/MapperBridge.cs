using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RevertIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertIndexer()
	{
	}
}
