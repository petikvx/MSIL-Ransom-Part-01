using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RateRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateRef()
	{
	}
}
