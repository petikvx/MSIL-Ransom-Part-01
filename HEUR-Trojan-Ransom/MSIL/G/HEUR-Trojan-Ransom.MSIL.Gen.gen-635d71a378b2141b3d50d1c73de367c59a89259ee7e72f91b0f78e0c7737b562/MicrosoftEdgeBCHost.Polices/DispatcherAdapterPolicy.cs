using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DispatcherAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralWatcher()
	{
	}
}
