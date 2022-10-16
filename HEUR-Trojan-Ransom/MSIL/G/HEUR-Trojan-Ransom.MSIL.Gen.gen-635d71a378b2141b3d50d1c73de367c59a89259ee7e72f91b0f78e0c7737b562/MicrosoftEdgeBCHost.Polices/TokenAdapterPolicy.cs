using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralStrategy()
	{
	}
}
