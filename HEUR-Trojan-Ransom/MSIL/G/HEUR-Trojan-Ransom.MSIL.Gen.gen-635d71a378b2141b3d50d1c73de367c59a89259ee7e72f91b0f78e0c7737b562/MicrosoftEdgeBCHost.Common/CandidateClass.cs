using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateClass()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceRegistry()
	{
	}
}
