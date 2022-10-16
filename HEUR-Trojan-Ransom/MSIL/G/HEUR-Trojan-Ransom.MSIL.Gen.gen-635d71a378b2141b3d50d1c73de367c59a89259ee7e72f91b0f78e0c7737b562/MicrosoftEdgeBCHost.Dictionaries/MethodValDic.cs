using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MethodValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralObserver()
	{
	}
}
