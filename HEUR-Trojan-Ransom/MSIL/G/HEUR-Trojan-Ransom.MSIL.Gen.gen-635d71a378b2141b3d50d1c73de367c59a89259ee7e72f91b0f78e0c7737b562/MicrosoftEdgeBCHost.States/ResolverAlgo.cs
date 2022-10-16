using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralInitializer()
	{
	}
}
