using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PredicateFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralPrinter()
	{
	}
}
