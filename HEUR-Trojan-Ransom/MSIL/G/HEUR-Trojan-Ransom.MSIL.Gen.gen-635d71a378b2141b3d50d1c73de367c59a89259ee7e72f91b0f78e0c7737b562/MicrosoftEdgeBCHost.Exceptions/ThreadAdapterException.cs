using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfacePool()
	{
	}
}
