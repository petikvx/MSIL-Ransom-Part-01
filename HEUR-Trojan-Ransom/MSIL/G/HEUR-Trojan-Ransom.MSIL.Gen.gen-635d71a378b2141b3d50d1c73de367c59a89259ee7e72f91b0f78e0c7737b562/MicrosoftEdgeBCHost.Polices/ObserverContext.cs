using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverContext()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceProducer()
	{
	}
}
