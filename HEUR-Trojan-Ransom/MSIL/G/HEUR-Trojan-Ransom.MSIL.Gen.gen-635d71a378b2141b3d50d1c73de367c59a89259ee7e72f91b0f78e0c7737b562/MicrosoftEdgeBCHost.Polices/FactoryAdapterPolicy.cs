using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralConfig()
	{
	}
}
