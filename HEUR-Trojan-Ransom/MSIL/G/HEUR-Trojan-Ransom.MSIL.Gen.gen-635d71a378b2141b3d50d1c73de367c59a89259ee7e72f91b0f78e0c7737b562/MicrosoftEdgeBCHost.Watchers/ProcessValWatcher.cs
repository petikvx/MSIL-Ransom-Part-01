using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcessValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceAuthentication()
	{
	}
}
