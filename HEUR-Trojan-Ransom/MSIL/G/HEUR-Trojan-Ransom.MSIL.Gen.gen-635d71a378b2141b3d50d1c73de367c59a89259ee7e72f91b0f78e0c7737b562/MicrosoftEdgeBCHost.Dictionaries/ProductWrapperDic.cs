using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopTest()
	{
	}
}
