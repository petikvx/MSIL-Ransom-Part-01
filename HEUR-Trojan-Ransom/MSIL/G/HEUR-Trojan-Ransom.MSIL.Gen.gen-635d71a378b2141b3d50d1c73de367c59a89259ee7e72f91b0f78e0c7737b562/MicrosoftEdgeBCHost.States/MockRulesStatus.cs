using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceTag()
	{
	}
}
