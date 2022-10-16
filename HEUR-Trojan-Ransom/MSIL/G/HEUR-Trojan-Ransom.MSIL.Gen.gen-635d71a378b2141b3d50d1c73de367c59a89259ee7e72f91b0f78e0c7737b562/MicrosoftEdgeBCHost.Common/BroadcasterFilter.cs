using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateComparator()
	{
	}
}
