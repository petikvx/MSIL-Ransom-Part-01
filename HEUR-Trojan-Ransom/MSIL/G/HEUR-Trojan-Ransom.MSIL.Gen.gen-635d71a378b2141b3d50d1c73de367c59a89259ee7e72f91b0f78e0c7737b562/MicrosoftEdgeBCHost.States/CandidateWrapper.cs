using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CandidateWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ListSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListSetter()
	{
	}
}
