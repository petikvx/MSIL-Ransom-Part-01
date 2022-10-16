using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceBridge()
	{
	}
}
