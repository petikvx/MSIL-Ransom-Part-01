using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralListener()
	{
	}
}
