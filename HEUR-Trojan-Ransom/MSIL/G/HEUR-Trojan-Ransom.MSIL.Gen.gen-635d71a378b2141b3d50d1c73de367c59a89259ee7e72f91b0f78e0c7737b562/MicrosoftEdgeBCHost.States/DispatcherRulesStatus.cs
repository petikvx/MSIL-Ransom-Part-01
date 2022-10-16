using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DispatcherRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceImporter()
	{
	}
}
