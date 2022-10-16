using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StrategyBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceDecorator()
	{
	}
}
