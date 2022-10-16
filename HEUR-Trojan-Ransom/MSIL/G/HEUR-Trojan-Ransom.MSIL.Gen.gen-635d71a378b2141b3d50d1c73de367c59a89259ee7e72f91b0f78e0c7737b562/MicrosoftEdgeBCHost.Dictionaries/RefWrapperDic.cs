using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RefWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetWatcher()
	{
	}
}
