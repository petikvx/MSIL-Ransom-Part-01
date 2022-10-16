using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GetterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralItem()
	{
	}
}
