using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapperWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralDic()
	{
	}
}
