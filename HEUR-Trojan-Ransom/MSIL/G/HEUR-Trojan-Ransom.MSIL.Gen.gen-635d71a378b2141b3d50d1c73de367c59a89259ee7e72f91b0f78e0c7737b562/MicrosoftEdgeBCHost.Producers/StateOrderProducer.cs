using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceProxy()
	{
	}
}
