using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProducerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceConnection()
	{
	}
}
