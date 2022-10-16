using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceStub()
	{
	}
}
