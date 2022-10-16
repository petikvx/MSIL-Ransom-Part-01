using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ImporterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceExporter()
	{
	}
}
