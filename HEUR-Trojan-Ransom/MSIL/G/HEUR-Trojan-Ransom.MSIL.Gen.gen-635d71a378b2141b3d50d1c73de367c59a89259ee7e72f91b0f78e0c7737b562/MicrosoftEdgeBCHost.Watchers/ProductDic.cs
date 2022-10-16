using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProductDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralTask()
	{
	}
}
