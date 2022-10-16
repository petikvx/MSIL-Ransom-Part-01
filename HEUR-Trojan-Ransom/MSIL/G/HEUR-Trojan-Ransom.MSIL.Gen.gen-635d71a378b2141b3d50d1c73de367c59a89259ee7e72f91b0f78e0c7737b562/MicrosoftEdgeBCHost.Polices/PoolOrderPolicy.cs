using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralException()
	{
	}
}
