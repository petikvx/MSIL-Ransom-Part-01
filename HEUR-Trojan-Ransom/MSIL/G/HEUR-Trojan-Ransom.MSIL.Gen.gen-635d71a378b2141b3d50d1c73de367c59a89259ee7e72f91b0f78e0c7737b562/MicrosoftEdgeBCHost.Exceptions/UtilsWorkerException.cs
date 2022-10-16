using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeResolver()
	{
	}
}
