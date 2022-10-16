using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveQueue()
	{
	}
}
