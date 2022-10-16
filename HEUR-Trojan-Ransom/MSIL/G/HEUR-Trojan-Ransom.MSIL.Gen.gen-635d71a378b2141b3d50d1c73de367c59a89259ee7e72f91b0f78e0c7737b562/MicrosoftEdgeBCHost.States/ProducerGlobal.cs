using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceCandidate()
	{
	}
}
