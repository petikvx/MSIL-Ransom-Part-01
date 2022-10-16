using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CancelPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelPrinter()
	{
	}
}
