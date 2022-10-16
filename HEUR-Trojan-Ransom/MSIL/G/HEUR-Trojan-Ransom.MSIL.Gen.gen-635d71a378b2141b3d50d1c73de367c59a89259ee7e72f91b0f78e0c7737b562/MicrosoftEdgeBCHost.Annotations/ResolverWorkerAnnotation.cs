using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ResolverWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralRequest()
	{
	}
}
