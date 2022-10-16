using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceOrder()
	{
	}
}
