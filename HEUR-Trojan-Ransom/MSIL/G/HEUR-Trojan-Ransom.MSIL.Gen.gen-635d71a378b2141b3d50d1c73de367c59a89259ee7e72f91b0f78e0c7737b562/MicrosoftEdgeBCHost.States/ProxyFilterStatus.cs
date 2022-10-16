using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProxyFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceWatcher()
	{
	}
}
