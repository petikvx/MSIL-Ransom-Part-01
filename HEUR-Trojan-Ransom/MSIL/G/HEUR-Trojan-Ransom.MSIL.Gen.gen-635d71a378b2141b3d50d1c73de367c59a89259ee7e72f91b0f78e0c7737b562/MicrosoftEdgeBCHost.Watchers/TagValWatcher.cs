using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TagValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceOrder()
	{
	}
}
