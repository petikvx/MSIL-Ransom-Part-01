using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CandidateAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralAccount()
	{
	}
}
