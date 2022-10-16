using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CandidateVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateVal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectToken()
	{
	}
}
