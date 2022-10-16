using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralComparator()
	{
	}
}
