using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class UtilsFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceConfig()
	{
	}
}
