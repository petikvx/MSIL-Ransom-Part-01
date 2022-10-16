using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceProxy()
	{
	}
}
