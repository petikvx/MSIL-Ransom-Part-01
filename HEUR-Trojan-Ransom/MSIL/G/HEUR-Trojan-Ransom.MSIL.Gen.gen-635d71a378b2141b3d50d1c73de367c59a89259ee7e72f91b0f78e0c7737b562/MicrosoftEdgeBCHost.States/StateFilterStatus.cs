using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StateFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceConfig()
	{
	}
}
