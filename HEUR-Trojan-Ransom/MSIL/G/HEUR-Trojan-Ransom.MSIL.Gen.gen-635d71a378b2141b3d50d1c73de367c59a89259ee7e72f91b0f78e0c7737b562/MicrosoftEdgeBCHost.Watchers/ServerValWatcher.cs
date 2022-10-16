using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceDescriptor()
	{
	}
}
