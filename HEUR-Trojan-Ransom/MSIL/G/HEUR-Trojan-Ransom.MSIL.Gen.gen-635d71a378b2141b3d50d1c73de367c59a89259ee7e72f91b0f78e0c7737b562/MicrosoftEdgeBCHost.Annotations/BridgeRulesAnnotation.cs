using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ViewRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewRecord()
	{
	}
}
