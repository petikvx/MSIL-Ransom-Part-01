using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilter()
	{
		WriterPropertyProducer.ResolveStub();
		RateIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateIterator()
	{
	}
}
