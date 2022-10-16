using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralCandidate()
	{
	}
}
