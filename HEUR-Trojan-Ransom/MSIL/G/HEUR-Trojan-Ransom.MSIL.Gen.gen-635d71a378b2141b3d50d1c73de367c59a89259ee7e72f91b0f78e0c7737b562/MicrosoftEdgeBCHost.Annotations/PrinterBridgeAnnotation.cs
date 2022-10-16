using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareService()
	{
	}
}
