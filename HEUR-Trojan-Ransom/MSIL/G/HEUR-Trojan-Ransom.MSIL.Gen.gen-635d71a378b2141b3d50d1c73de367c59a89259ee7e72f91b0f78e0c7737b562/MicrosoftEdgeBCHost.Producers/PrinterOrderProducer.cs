using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrinterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceClass()
	{
	}
}
