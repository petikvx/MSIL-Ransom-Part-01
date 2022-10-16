using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DecoratorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountWatcher()
	{
	}
}
