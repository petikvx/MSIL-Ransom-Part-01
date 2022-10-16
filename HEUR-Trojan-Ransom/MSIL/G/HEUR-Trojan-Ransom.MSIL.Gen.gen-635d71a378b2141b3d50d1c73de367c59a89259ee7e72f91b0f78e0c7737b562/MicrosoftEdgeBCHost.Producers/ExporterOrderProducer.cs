using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralInstance()
	{
	}
}
