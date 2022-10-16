using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClientOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceProc()
	{
	}
}
