using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductValDic()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralMock()
	{
	}
}
