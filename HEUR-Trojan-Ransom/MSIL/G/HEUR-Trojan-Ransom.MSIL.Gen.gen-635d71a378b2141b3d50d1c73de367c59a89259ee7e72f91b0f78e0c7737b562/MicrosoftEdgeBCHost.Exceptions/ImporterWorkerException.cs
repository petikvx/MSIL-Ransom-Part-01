using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterpreter()
	{
	}
}
