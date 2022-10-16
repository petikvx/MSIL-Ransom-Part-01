using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StrategyValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralTokenizer()
	{
	}
}
