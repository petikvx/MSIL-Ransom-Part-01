using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostDic()
	{
	}
}
