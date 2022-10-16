using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BroadcasterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralInstance()
	{
	}
}
