using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralRule()
	{
	}
}
