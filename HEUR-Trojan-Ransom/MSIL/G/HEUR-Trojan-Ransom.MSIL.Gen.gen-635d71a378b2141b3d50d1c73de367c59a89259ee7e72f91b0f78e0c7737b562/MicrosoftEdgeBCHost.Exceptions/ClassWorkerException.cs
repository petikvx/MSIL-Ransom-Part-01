using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClassWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RestartException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartException()
	{
	}
}
