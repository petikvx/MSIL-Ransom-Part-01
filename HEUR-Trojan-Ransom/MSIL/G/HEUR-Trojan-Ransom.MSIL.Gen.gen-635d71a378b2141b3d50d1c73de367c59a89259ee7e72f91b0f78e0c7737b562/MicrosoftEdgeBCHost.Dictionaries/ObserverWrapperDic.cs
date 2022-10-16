using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObserverWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateParam()
	{
	}
}
