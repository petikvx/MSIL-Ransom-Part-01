using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SystemOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceProcess()
	{
	}
}
