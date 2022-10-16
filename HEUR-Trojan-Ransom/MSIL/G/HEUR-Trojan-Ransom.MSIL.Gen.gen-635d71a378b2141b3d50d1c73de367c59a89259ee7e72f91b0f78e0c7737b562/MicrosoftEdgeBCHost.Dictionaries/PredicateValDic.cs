using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PredicateValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralItem()
	{
	}
}
