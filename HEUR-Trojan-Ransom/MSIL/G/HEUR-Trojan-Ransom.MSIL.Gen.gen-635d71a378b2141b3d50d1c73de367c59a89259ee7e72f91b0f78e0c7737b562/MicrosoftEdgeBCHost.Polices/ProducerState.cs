using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProducerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerState()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceProxy()
	{
	}
}
