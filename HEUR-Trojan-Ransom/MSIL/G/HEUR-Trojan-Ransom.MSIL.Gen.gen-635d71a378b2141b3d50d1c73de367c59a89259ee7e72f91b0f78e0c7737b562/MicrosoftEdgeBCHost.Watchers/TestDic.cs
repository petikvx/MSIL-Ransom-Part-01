using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestDic()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralInfo()
	{
	}
}
