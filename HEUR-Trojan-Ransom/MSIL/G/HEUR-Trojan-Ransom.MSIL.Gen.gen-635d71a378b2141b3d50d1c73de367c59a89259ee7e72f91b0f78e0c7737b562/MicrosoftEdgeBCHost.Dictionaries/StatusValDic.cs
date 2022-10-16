using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StatusValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusValDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralPredicate()
	{
	}
}
