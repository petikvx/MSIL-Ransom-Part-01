using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProducerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeListener()
	{
	}
}
