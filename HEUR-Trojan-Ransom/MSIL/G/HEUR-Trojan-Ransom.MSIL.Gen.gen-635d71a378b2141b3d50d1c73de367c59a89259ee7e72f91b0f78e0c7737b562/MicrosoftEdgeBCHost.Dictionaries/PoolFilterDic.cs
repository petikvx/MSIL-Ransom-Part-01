using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PoolFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralDispatcher()
	{
	}
}
