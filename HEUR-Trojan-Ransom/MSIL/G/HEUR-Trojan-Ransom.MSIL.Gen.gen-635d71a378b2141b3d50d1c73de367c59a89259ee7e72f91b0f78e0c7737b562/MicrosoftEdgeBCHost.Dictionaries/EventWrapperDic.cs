using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetException()
	{
	}
}
