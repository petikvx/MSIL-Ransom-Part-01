using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrinterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RevertRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertRecord()
	{
	}
}
