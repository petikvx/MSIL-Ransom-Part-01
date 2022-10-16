using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProducerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceIdentifier()
	{
	}
}
