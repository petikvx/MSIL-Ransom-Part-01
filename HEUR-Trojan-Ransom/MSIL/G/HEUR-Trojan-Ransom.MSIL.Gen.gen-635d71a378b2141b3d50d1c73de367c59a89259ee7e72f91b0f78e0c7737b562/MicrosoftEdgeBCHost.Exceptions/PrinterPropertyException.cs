using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrinterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralAnnotation()
	{
	}
}
