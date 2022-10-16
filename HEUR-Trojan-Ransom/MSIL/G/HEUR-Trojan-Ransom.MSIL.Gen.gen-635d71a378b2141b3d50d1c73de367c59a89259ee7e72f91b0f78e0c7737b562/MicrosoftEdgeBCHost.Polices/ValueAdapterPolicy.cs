using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralIterator()
	{
	}
}
