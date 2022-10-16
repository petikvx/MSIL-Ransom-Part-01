using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WatcherFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralDecorator()
	{
	}
}
