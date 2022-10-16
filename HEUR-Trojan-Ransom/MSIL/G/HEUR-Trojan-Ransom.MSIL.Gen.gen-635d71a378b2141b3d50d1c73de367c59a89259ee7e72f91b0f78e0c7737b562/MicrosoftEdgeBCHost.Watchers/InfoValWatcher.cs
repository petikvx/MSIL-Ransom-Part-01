using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InfoValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceException()
	{
	}
}
