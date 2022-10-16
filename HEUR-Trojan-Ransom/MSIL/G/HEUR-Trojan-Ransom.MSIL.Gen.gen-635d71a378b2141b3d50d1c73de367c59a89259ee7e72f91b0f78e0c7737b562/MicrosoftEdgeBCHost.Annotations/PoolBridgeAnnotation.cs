using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PoolBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CloneTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneTests()
	{
	}
}
