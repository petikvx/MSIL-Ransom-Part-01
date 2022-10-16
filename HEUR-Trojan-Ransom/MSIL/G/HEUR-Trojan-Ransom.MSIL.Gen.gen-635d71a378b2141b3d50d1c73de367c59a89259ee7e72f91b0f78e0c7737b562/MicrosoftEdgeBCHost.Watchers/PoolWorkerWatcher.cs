using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralDic()
	{
	}
}
