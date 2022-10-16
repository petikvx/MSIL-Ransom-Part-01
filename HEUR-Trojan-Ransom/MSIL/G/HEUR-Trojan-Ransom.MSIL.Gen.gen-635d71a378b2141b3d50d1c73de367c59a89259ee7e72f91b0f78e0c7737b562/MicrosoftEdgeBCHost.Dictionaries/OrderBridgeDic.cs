using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortTask()
	{
	}
}
