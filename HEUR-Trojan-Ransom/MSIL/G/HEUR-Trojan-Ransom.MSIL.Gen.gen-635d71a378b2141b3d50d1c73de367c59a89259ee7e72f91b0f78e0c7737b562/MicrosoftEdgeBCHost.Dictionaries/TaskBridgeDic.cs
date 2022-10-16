using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TaskBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountStruct()
	{
	}
}
