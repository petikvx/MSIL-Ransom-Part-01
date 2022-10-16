using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterpreterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchWriter()
	{
	}
}
