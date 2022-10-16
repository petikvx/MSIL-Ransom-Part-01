using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceParams()
	{
	}
}
