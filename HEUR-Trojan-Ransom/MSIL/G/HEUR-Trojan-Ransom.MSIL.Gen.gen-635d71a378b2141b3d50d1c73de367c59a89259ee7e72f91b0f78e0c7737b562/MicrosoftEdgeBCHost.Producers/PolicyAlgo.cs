using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralResolver()
	{
	}
}
