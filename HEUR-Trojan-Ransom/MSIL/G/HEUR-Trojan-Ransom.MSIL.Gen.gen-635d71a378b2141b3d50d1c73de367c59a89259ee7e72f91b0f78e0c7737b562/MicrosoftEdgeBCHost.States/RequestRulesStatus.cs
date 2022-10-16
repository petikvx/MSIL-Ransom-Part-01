using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RequestRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceAlgo()
	{
	}
}
