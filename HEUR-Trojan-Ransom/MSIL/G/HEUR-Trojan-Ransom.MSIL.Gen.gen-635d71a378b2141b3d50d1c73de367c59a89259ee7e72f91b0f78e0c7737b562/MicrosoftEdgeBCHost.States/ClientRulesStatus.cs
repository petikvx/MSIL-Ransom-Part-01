using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceInitializer()
	{
	}
}
