using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComparatorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralClient()
	{
	}
}
