using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralProperty()
	{
	}
}
