using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceAttr()
	{
	}
}
