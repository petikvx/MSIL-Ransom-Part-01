using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ThreadOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceCallback()
	{
	}
}
