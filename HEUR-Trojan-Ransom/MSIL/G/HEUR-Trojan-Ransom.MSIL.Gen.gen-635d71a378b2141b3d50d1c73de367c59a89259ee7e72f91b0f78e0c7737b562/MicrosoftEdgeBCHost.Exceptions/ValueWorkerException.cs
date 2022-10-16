using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValueWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeProduct()
	{
	}
}
