using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClassFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceInterceptor()
	{
	}
}
