using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProductRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ViewTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewTemplate()
	{
	}
}
