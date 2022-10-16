using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrinterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralServer()
	{
	}
}
