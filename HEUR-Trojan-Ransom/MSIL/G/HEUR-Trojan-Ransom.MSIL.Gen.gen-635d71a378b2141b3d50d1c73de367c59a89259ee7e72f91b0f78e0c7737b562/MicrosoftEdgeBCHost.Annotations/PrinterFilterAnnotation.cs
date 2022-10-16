using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceModel()
	{
	}
}
