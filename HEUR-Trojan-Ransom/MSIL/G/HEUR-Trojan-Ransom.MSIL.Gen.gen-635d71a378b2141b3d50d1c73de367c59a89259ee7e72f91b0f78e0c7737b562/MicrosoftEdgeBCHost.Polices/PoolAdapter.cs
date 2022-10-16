using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceMapping()
	{
	}
}
