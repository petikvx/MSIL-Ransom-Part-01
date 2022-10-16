using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryConfig()
	{
	}
}
