using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProductOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralClass()
	{
	}
}
