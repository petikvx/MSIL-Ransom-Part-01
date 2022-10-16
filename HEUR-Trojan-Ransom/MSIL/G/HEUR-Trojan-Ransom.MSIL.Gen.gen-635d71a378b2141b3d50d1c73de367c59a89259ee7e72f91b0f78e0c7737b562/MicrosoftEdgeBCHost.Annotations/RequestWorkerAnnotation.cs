using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralTag()
	{
	}
}
