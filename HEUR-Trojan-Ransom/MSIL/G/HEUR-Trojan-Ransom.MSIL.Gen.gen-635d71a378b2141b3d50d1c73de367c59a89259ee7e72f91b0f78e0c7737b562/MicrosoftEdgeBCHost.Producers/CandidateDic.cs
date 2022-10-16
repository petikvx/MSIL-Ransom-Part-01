using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CandidateDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralCallback()
	{
	}
}
