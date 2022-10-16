using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceConsumer()
	{
	}
}
