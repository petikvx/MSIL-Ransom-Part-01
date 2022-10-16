using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StatusBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareSerializer()
	{
	}
}
