using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineTask()
	{
	}
}
