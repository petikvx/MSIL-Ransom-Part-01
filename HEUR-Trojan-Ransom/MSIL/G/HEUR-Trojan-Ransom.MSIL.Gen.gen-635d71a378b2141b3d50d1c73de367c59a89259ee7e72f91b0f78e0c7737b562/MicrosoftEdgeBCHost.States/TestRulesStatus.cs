using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceValue()
	{
	}
}
