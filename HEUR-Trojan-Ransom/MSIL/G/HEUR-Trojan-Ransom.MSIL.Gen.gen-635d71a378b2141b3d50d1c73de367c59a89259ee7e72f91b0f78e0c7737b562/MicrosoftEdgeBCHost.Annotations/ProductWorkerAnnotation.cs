using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProductWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralRef()
	{
	}
}
