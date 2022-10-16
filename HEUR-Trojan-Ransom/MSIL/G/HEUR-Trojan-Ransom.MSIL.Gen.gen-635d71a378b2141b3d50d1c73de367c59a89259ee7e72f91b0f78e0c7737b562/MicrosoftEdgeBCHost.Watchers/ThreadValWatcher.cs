using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceMessage()
	{
	}
}
