using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PoolValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralClass()
	{
	}
}
