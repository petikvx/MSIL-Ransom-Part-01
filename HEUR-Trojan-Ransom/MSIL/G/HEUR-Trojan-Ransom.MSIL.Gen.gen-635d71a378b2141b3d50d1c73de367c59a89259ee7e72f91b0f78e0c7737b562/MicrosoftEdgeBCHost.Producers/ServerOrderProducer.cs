using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceOrder()
	{
	}
}
