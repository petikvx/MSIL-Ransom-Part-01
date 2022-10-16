using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SpecificationRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceExporter()
	{
	}
}
