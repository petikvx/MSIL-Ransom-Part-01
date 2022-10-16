using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CallbackWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterpreter()
	{
	}
}
