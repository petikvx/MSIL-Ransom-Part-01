using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BroadcasterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralPredicate()
	{
	}
}
