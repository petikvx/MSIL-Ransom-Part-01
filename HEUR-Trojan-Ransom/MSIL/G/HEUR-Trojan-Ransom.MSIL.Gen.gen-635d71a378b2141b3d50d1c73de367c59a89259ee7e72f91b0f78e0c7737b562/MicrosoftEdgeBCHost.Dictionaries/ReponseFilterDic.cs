using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReponseFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceInterceptor()
	{
	}
}
