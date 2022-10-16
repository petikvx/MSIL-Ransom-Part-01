using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class QueueWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokePrinter()
	{
	}
}
