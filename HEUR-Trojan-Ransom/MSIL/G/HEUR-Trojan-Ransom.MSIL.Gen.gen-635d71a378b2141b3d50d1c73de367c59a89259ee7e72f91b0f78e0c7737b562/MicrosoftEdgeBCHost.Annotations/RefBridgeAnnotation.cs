using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RefBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareCollection()
	{
	}
}
