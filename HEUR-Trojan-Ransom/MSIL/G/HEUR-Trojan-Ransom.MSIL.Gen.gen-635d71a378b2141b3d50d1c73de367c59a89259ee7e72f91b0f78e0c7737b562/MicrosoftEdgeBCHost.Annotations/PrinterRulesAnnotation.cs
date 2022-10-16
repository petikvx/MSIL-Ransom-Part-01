using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckObserver()
	{
	}
}
