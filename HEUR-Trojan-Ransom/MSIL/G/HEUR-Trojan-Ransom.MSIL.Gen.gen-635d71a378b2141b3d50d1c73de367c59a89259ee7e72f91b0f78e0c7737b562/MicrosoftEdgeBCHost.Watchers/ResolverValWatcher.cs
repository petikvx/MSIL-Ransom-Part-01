using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceAuthentication()
	{
	}
}
