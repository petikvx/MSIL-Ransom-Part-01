using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CreateCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateCandidate()
	{
	}
}
