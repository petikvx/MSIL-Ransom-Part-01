using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceWriter()
	{
	}
}
