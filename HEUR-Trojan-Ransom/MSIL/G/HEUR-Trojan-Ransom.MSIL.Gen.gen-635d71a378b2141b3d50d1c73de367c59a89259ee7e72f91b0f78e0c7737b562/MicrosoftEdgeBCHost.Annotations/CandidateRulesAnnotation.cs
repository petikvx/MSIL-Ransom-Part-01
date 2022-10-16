using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CandidateRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeReponse()
	{
	}
}
