using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FilterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceOrder()
	{
	}
}
