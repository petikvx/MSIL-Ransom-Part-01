using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateState()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceInitializer()
	{
	}
}
