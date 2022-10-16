using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceWorker()
	{
	}
}
