using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InstanceBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteList()
	{
	}
}
