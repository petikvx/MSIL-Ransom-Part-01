using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceExporter()
	{
	}
}
