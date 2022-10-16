using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceRole()
	{
	}
}
