using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrinterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupRepository()
	{
	}
}
