using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceClass()
	{
	}
}
