using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterpreter()
	{
	}
}
