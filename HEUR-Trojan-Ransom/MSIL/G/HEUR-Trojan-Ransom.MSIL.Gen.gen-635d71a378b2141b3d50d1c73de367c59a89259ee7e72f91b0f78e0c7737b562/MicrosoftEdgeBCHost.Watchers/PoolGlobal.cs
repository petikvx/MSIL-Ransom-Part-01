using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceFacade()
	{
	}
}
