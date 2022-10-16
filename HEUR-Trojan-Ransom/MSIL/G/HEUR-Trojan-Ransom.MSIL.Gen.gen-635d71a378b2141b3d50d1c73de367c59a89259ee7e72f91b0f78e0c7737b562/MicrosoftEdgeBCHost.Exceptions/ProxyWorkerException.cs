using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PushDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushDispatcher()
	{
	}
}
