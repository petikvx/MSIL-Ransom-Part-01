using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralDic()
	{
	}
}
