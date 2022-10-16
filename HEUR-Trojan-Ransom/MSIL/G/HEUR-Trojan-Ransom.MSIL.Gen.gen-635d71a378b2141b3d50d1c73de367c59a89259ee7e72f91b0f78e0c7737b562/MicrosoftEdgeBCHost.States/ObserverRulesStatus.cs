using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceAttr()
	{
	}
}
