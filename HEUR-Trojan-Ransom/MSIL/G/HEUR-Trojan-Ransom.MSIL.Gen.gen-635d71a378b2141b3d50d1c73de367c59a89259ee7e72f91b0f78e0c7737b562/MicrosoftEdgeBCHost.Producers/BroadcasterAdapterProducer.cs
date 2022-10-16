using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralExporter()
	{
	}
}
