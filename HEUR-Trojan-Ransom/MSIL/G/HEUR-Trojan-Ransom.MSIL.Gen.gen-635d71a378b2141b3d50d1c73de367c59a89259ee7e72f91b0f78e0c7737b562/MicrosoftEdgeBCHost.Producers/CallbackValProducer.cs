using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CallbackValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortComparator()
	{
	}
}
