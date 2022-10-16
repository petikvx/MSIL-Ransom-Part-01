using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralComparator()
	{
	}
}
