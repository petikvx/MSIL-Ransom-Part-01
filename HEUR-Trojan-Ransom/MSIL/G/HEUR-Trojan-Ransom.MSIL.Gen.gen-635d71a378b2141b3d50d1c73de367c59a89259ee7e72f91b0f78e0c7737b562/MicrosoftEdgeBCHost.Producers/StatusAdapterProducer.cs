using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralExporter()
	{
	}
}
