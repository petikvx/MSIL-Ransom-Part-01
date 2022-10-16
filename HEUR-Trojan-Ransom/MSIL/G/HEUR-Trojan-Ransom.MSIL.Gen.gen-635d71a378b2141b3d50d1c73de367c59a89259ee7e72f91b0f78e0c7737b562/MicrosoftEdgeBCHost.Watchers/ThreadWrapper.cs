using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CloneDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneDic()
	{
	}
}
