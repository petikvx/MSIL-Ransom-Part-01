using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceTests()
	{
	}
}
