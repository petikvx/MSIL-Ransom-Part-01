using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BroadcasterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteFilter()
	{
	}
}
