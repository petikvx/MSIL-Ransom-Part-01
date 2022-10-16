using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServiceRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceResolver()
	{
	}
}
