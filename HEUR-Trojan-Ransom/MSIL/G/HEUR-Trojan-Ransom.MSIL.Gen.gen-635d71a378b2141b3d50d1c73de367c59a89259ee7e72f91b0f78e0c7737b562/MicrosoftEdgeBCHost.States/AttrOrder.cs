using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrOrder()
	{
		WriterPropertyProducer.ResolveStub();
		SetObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetObserver()
	{
	}
}
