using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectProduct()
	{
	}
}
