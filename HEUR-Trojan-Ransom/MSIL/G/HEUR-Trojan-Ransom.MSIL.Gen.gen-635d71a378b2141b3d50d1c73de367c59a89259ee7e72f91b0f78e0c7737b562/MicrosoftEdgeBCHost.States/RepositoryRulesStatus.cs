using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceResolver()
	{
	}
}
