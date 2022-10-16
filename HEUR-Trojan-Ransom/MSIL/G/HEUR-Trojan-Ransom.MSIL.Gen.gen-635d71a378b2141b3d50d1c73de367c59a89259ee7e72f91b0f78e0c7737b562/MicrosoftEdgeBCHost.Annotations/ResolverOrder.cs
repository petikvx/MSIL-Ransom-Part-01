using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ResolverOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverOrder()
	{
		WriterPropertyProducer.ResolveStub();
		SortBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortBase()
	{
	}
}
