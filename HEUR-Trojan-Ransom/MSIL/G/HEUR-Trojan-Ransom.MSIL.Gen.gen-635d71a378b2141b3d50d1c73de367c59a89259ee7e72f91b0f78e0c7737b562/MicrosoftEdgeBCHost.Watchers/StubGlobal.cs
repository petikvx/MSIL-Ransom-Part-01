using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceOrder()
	{
	}
}
