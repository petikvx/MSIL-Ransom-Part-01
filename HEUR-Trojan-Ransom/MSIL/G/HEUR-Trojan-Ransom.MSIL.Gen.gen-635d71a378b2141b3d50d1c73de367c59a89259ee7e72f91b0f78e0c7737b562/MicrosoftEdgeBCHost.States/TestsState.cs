using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsState()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceOrder()
	{
	}
}
