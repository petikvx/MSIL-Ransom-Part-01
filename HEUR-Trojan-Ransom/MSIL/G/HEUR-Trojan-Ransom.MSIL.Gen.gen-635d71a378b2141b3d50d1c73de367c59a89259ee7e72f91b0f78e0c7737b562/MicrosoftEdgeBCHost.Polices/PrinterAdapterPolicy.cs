using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralField()
	{
	}
}
