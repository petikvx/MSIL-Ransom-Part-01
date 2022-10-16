using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class QueueOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceParams()
	{
	}
}
