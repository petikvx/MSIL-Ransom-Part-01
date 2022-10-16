using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ManagerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceContext()
	{
	}
}
