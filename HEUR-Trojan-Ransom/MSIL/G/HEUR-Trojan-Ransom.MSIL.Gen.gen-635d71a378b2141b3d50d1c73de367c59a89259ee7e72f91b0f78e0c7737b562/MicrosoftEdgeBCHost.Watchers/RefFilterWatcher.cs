using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceManager()
	{
	}
}
