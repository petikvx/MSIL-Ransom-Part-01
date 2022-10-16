using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralWorker()
	{
	}
}
