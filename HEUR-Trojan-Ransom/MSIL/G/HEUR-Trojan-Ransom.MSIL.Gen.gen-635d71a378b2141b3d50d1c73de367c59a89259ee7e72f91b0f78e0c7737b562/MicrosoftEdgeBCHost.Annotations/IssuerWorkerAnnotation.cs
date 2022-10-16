using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IssuerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralRules()
	{
	}
}
