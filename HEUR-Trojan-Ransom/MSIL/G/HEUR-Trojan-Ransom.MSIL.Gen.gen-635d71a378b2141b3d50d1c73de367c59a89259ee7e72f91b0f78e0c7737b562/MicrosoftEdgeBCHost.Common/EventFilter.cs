using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventFilter()
	{
		WriterPropertyProducer.ResolveStub();
		RunCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunCandidate()
	{
	}
}
