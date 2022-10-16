using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WrapperWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PushQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushQueue()
	{
	}
}
