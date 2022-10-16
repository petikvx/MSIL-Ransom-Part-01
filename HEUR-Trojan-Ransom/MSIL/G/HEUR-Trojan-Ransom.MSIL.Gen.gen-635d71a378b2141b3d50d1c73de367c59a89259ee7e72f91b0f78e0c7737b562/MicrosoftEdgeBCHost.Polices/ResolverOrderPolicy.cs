using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ResolverOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralTests()
	{
	}
}
