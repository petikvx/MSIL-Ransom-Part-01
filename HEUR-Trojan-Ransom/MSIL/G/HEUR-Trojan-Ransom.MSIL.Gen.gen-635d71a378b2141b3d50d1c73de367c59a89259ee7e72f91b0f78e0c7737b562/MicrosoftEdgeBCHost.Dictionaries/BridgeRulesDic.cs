using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceAdapter()
	{
	}
}
