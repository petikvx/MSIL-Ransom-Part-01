using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceAuthentication()
	{
	}
}
