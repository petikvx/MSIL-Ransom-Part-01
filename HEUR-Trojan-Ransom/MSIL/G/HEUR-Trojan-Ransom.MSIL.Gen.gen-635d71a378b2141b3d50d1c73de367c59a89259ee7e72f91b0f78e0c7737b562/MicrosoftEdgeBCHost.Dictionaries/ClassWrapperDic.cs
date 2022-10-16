using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClassWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitAlgo()
	{
	}
}
