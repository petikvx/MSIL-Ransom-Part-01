using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatConsumer()
	{
	}
}
