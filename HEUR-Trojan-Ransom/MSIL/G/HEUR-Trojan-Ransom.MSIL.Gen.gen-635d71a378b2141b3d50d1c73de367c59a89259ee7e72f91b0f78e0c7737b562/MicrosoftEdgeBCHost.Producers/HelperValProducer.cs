using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectExporter()
	{
	}
}
