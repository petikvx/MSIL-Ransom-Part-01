using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralProperty()
	{
	}
}
