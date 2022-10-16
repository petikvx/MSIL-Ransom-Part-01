using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralCandidate()
	{
	}
}
