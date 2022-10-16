using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExceptionWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitPrinter()
	{
	}
}
