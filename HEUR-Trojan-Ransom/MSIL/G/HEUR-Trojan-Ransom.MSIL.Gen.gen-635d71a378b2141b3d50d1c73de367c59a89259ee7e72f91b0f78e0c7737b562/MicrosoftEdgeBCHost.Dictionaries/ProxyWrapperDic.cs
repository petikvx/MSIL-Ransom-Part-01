using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProxyWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcState()
	{
	}
}
