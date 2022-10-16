using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralCallback()
	{
	}
}
