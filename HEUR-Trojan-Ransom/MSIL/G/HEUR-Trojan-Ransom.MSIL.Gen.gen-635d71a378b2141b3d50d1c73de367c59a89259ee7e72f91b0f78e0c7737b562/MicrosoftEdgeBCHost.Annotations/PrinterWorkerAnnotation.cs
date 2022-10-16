using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralProducer()
	{
	}
}
