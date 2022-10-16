using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceVisitor()
	{
	}
}
