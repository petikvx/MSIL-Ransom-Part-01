using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceStrategy()
	{
	}
}
