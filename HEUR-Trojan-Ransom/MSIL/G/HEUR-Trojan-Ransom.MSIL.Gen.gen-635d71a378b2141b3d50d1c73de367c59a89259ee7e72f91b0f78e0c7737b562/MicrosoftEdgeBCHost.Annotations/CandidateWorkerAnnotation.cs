using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CandidateWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralProducer()
	{
	}
}
