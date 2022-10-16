using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceExporter()
	{
	}
}
