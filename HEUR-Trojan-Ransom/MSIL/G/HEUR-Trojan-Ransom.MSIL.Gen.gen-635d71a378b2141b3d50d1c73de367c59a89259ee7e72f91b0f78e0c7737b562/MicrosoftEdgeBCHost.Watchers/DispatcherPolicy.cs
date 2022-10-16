using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceCallback()
	{
	}
}
