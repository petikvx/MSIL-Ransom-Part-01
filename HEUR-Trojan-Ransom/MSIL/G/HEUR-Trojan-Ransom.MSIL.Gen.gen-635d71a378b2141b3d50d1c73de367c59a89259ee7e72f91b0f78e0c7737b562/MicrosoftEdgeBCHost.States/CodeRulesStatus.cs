using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceBroadcaster()
	{
	}
}
