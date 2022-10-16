using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InitializerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralPredicate()
	{
	}
}
