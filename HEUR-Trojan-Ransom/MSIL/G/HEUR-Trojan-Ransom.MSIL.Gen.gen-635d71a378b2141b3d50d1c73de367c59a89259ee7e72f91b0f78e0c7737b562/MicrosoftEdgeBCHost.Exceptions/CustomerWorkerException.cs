using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewCallback()
	{
	}
}
