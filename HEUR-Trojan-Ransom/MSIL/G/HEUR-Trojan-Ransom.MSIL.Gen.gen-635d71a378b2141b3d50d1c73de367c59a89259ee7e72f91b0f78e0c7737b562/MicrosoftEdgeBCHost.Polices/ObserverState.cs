using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverState()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceProperty()
	{
	}
}
